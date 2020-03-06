using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }
        public string metin;

        public int iteritonKey { get; private set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sifreleme sec = new Sifreleme();
            sec.DosyaSecOku();
            DosyaMetin.Text = sec.metin;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SifrelenecekMetin = string.Empty;
            SifrelenecekMetin = DosyaMetin.Text;
            Sifreleme okuSifrele = new Sifreleme();
            okuSifrele.Sifrele(SifrelenecekMetin);
            DosyaMetin.Text = okuSifrele.SifrelenenMetin;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string SifreCozulecekMetin = string.Empty;
            SifreCozulecekMetin = DosyaMetin.Text;
            Sifreleme sifreCozen = new Sifreleme();
            sifreCozen.SıfreCoz(SifreCozulecekMetin);
            DosyaMetin.Text = sifreCozen.sıfreCozulenMetin;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setting sf = new Setting();
            
            
            
           
            
           

        }
    }
}
