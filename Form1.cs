namespace Punisher
{
    public partial class Form1 : Form
    {
        Temizleyici TemizleyiciClass = new Temizleyici();
        Logger Logçu;
        
        public Form1()
        {
            InitializeComponent();
            Logçu = new Logger(richTbxLog);
        }


        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            //richTbxLog.AppendText("İşlemler Başlatıldı \n");
            
            Logçu.Log("İşlemler Başlatıldı");

            if (chkboxÇöpKutusuTemizle.Checked)
                TemizleyiciClass.ÇöpKutusuTemizle();
            if (chkboxTarayıcılarıTemizle.Checked)
                TemizleyiciClass.TarayıcıTemizle();
        }

        public void HoşgeldinMesajıYazdır()
        {
            Logçu.Log("Hoşgeldiniz");
        }

        public void HoşgeldinMesajıYazdır(string mesaj)
        {
            Logçu.Log(mesaj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TemizleyiciClass.deneme();
        }
    }
}
