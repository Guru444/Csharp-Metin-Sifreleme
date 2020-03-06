using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DosyaOkuma
    {
        public void AyarDosyasıOku()
        {
            
            string filePath = "C:\\Users\\ELAB\\Documents\\Visual Studio 2013\\Settings.txt";
            StreamReader sr = new StreamReader(File.OpenRead(filePath));
            metin = sr.ReadToEnd();
            sr.Dispose();

            Console.ReadKey();
 

        }

        public string metin { get; set; }
    }
}
