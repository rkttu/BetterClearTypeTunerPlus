using System;
using System.Runtime.InteropServices;

namespace BetterClearTypeTunerPlus.Native
{
	internal static class NativeMethods
	{
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SystemParametersInfoW(SPI uiAction, uint uiParam, ref uint pvParam, SPIF fWinIni); // Overloads can be made where pvParam can be any type

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SystemParametersInfoW(SPI uiAction, uint uiParam, uint pvParam, SPIF fWinIni);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SystemParametersInfoW(SPI uiAction, uint uiParam, ref bool pvParam, SPIF fWinIni);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SystemParametersInfoW(SPI uiAction, bool uiParam, IntPtr pvParam, SPIF fWinIni);
    }
}
