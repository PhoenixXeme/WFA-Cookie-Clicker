namespace WFA_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string filePath = "data.txt";
        static public int cookie = 0;
        static CookieStorage cookieStorage = new CookieStorage(filePath);

        public static int stoneUpg = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shop1.Hide();
            settings1.Hide();

            cookie = cookieStorage.Load();
            lbl_cookie.Text = cookie.ToString();
        }

        private void btn_cookie_Click(object sender, EventArgs e)
        {
            cookie += 1 + stoneUpg;
            lbl_cookie.Text = cookie.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            shop1.Show();
            shop1.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            shop1.Hide();
            settings1.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            cookieStorage.Save(cookie);
        }

        private void shop1_Load(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settings1.Show();
            settings1.BringToFront();
        }

        private void lbl_cookies_Click(object sender, EventArgs e)
        {

        }
    }


    public class CookieStorage
    {
        private readonly string _path;

        public CookieStorage(string path)
        {
            _path = path;
        }

        public int Load()
        {
            try 
            {
                string data = File.ReadAllText(_path);
                return int.Parse(data);
            }
            catch 
            {
                Save(0);
                return 0;
            }
            
        }

        public void Save(int cookieCount)
        {
            string data = cookieCount.ToString();
            File.WriteAllText(_path, data);
        }
    }

}