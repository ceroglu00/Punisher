using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punisher
{
    internal class Temizleyici
    {

        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
            SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
            SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);


        public void ÇöpKutusuTemizle()
        {
            uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
        }

        public void TarayıcıTemizle()
        {

            // Edge kapatılacak
            var işlemler = Process.GetProcesses();

            for (int i = 0; i < işlemler.Length; i++)
            {
                var şuankiİşlem = işlemler[i];
                if (şuankiİşlem.ProcessName == "msedge")
                {
                    şuankiİşlem.Kill();
                }

            }
            // Edge Kapandı



            // Dosya yoluna gidecek
            // Dosyayı bulup temizleyecek
            var MsEdgeHistoryYolu = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "Local");
            MsEdgeHistoryYolu += "\\Microsoft\\Edge\\User Data\\Default\\History";

            if (!File.Exists(MsEdgeHistoryYolu))
                return;


            SilmeİşlemiBaşlangıcı:
            File.Delete(MsEdgeHistoryYolu);


            if (!File.Exists(MsEdgeHistoryYolu))
            {
                //Dosya başarıyla Silindi
            }
            else
            {
                //Silerken bir hata oldu galiba
                goto SilmeİşlemiBaşlangıcı;
            }
            // Dosya bulundu ve silindi


        }

        public void deneme()
        {
        }

    }
}
