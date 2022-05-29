using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DisplayResolutionManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
			this.RefreshSettings();
		}

		private void RefreshSettings()
		{
			this.lblCurrent.Text = PrmaryScreenResolution.GetSettings() ?? "-";
		}

		private bool ChangeResolution(int width, int height, int frequency, Scales scale)
		{
			string error = PrmaryScreenResolution.ChangeResolution(width, height, frequency);
			if (error != null)
			{
				MessageBox.Show(error, "Ошибка");
				return false;
			}

			this.RefreshSettings();

			User_32.SystemParametersInfo(0x009F, (uint)scale, 0, 1);

			return true;
		}

		private void btnProfile1920_60_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangeResolution(1920, 1080, 60, Scales.Scale100);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void btnProfile1920_144_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangeResolution(1920, 1080, 144, Scales.Scale100);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void btnProfile2560_60_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangeResolution(2560, 1440, 60, Scales.Scale125);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void btnProfile2560_144_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangeResolution(2560, 1440, 144, Scales.Scale125);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void btnProfile3840_60_Click(object sender, EventArgs e)
		{
			try
			{
				this.ChangeResolution(3840, 2160, 60, Scales.Scale150);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

	public enum Scales : uint
	{
		Scale100 = 0,
		Scale125 = 1,
		Scale150 = 2,
		Scale175 = 3,
		ScaleX = 4,
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct DEVMODE1
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;
		public short dmSpecVersion;
		public short dmDriverVersion;
		public short dmSize;
		public short dmDriverExtra;
		public int dmFields;

		public short dmOrientation;
		public short dmPaperSize;
		public short dmPaperLength;
		public short dmPaperWidth;

		public short dmScale;
		public short dmCopies;
		public short dmDefaultSource;
		public short dmPrintQuality;
		public short dmColor;
		public short dmDuplex;
		public short dmYResolution;
		public short dmTTOption;
		public short dmCollate;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;
		public short dmLogPixels;
		public short dmBitsPerPel;
		public int dmPelsWidth;
		public int dmPelsHeight;

		public int dmDisplayFlags;
		public int dmDisplayFrequency;

		public int dmICMMethod;
		public int dmICMIntent;
		public int dmMediaType;
		public int dmDitherType;
		public int dmReserved1;
		public int dmReserved2;

		public int dmPanningWidth;
		public int dmPanningHeight;
	};

	public class User_32
	{
		[DllImport("user32.dll")]
		public static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE1 devMode);
		[DllImport("user32.dll")]
		public static extern int ChangeDisplaySettings(ref DEVMODE1 devMode, int flags);

		[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
		public static extern bool SystemParametersInfo(
			uint uiAction,
			uint uiParam,
			uint pvParam,
			uint fWinIni);

		public const int ENUM_CURRENT_SETTINGS = -1;
		public const int CDS_UPDATEREGISTRY = 0x01;
		public const int CDS_TEST = 0x02;
		public const int DISP_CHANGE_SUCCESSFUL = 0;
		public const int DISP_CHANGE_RESTART = 1;
		public const int DISP_CHANGE_FAILED = -1;
	}

	public class PrmaryScreenResolution
	{
		public static string GetSettings()
		{
			DEVMODE1 dm = GetDevMode1();

			if (User_32.EnumDisplaySettings(null, User_32.ENUM_CURRENT_SETTINGS, ref dm) != 0)
			{
				return $"{dm.dmPelsWidth} x {dm.dmPelsHeight} ({dm.dmDisplayFrequency} Гц)";
			}
			return null;
		}

		public static string ChangeResolution(int width, int height, int frequency)
		{
			DEVMODE1 dm = GetDevMode1();

			if (User_32.EnumDisplaySettings(null, User_32.ENUM_CURRENT_SETTINGS, ref dm) != 0)
			{
				dm.dmPelsWidth = width;
				dm.dmPelsHeight = height;
				dm.dmDisplayFrequency = frequency;

				int iRet = User_32.ChangeDisplaySettings(ref dm, User_32.CDS_TEST);

				if (iRet == User_32.DISP_CHANGE_FAILED)
				{
					return "Unable To Process Your Request. Sorry For This Inconvenience.";
				}
				else
				{
					iRet = User_32.ChangeDisplaySettings(ref dm, User_32.CDS_UPDATEREGISTRY);
					switch (iRet)
					{
						case User_32.DISP_CHANGE_SUCCESSFUL:
							{
								return null;
							}
						case User_32.DISP_CHANGE_RESTART:
							{
								return "You Need To Reboot For The Change To Happen.\n If You Feel Any Problem After Rebooting Your Machine\nThen Try To Change Resolution In Safe Mode.";
							}
						default:
							{
								return "Failed To Change The Resolution";
							}
					}
				}
			}
			else
			{
				return "Failed To Change The Resolution.";
			}
		}

		private static DEVMODE1 GetDevMode1()
		{
			DEVMODE1 dm = new DEVMODE1();
			dm.dmDeviceName = new String(new char[32]);
			dm.dmFormName = new String(new char[32]);
			dm.dmSize = (short)Marshal.SizeOf(dm);
			return dm;
		}
	}
}