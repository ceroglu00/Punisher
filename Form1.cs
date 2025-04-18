namespace Punisher
{
    public partial class Form1 : Form
    {
        Temizleyici TemizleyiciClass = new Temizleyici();
        Logger Logçu = new Logger();

        public Form1()
        {
            InitializeComponent();
            Logçu.Log("Uygulamaya Hoşgeldiniz.",richTbxLog);
        }

        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            //richTbxLog.AppendText("İşlemler Başlatıldı \n");
            
            Logçu.Log("İşlemler Başlatıldı",richTbxLog);

            if (chkboxÇöpKutusuTemizle.Checked)
                TemizleyiciClass.ÇöpKutusuTemizle();
            if (chkboxTarayıcılarıTemizle.Checked)
                TemizleyiciClass.TarayıcıTemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TemizleyiciClass.deneme();
        }
    }
}
