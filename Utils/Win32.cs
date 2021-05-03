using System;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Config.Utils
{
    internal static class Utils
    {
        internal static void SafeSetIndex(ComboBox box, int index)
        {
            if (index >= box.Items.Count)
                index = box.Items.Count - 1;
            box.SelectedIndex = index;
        }
    }
    internal class Resolution
    {
        protected bool Equals(Resolution other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X*397) ^ Y;
            }
        }

        internal readonly int X;
        internal readonly int Y;

        internal Resolution(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("{0}x{1}", X, Y);
        }

        public override bool Equals(Object obj)
        {
            Resolution p = obj as Resolution;
            return (object) p != null && Equals(p);
        }

        public static bool operator ==(Resolution a, Resolution b)
        {
            return ((a.X == b.X) && (a.Y == b.Y));
        }

        public static bool operator !=(Resolution a, Resolution b)
        {
            return ((a.X != b.X) || (a.Y != b.Y));
        }

    }


    internal static class Win32
    {


       

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
            string deviceName, int modeNum, ref DEVMODE devMode);

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {

            private const int Cchdevicename = 0x20;
            private const int Cchformname = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)] public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)] public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
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

        }

        internal static List<Resolution> EnumAvailableResolutions()
        {
            var ret = new List<Resolution>();
            var vDevMode = new DEVMODE();
            int i = 0;
            while (EnumDisplaySettings(null, i, ref vDevMode))
            {
                var res = new Resolution(vDevMode.dmPelsWidth, vDevMode.dmPelsHeight);

                if (!ret.Contains(res))
                    ret.Add(res);
                i++;
            }
            return ret;
        }


    }
}

