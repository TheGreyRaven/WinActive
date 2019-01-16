
using System;
using System.IO;

namespace WinActive
{
    class Functions
    {
        public static bool Is64Bit()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void WriteResources()
        {
            File.WriteAllText(Path.GetTempPath() + "\\WinActiveData\\KMS_VL_ALL.cmd", Properties.Resources.KMS_VL_ALL);
            File.WriteAllBytes(Path.GetTempPath() + "\\WinActiveData\\32-bit\\SECOPatcher.dll", Properties.Resources.SECOPatcher);
            File.WriteAllBytes(Path.GetTempPath() + "\\WinActiveData\\32-bit\\vlmcsd.exe", Properties.Resources.vlmcsd);
            File.WriteAllBytes(Path.GetTempPath() + "\\WinActiveData\\64-bit\\SECOPatcher.dll", Properties.Resources.SECOPatcher);
        }
    }
}
