using LPROS.Custom;
using LPROS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private String USERNAME_OR_PASSWORD_NULL = "Lütfen Boş Yerleri Doldurunuz";
        private String USERNAME_OR_PASSWORD_FALSE = "Kullanıcı Adı veya Şifre Yanlış";

        private void Login_Load(object sender, EventArgs e)
        {
            IMAGE_USERNAME.Image = IMAGELIST_LOGIN.Images[0];
            IMAGE_PASSWORD.Image = IMAGELIST_LOGIN.Images[1];

            this.LABEL_NOT_LOGIN_INFO.Visible = false;
            label_head.Select();

            new FormTasima(panel_head, label_head, this, pictureBox_close, pictureBox_minimize);

            this.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            this.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            this.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;

            pictureBox_icon.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            pictureBox_icon.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            pictureBox_icon.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;
        }

        private void TEXT_USERNAME_Enter(object sender, EventArgs e)
        {
            if (TEXT_USERNAME.Text == "Kullanıcı Adı")
                TEXT_USERNAME.Text = "";
        }

        private void TEXT_USERNAME_Leave(object sender, EventArgs e)
        {
            if (TEXT_USERNAME.Text.Length == 0)
                TEXT_USERNAME.Text = "Kullanıcı Adı";
        }

        private void TEXT_PASSWORD_Enter(object sender, EventArgs e)
        {
            if (TEXT_PASSWORD.Text == "Şifre")
            {
                TEXT_PASSWORD.Text = "";
                TEXT_PASSWORD.PasswordChar = '*';
            }
        }

        private void TEXT_PASSWORD_Leave(object sender, EventArgs e)
        {
            if (TEXT_PASSWORD.Text.Length == 0)
            {
                TEXT_PASSWORD.Text = "Şifre";
                TEXT_PASSWORD.PasswordChar = '\0';
            }
        }


        private bool DRAGGİNG;
        private Point OFFSET;
        private void PICTURE_HEAD_BACKGROUND_MouseDown(object sender, MouseEventArgs e)
        {
            DRAGGİNG = true;
            OFFSET = e.Location;
        }

        private void PICTURE_HEAD_BACKGROUND_MouseUp(object sender, MouseEventArgs e)
        {
            DRAGGİNG = false;
        }

        private void PICTURE_HEAD_BACKGROUND_MouseMove(object sender, MouseEventArgs e)
        {
            if (DRAGGİNG)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - OFFSET.X, currentScreenPos.Y - OFFSET.Y);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void PANEL_TEXT_USERNAME_Click(object sender, EventArgs e)
        {
            TEXT_USERNAME.Focus();
        }

        private void PANEL_TEXT_PASSWORD_Click(object sender, EventArgs e)
        {
            TEXT_PASSWORD.Focus();
        }

        private void login()
        {
            String USER_NAME = this.TEXT_USERNAME.Text.ToString();
            String PASSWORD = this.TEXT_PASSWORD.Text.ToString();

            if (USER_NAME != "Kullanıcı Adı" && PASSWORD != "Şifre")
            {
                SqlCommand SC_USERNAME_PASSWORD = new SqlCommand("Select * From Personel Where kullanici_adi=" +
                "@USERNAME and sifre=@PASSWORD", Sc.CON);

                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@USERNAME", USER_NAME);
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                try
                {
                    Sc.setCON_EMPTY(true);
                    int TABLE_COUNT = Convert.ToInt32(SC_USERNAME_PASSWORD.ExecuteScalar());

                    if (TABLE_COUNT != 0)
                    {
                        DataTable dt = Sc.GET_DATATABLE("select * from Personel where kullanici_adi=@parametre1 and sifre=@parametre2", new string[] { USER_NAME, PASSWORD });
                        User.id = dt.Rows[0]["personel_no"].ToString();
                        User.yetki_id = dt.Rows[0]["yetki_id"].ToString();
                        User.yetki_tipi = Sc.GET_TEKDEGER("select yetki_turu from Yetkiler where Id=@parametre1", new string[] { User.yetki_id });
                        User.ad = dt.Rows[0]["ad"].ToString();
                        User.soyad = dt.Rows[0]["soyad"].ToString(); ;

                        Sc.setCON_EMPTY(false);
                        (new Main()).Show();
                        this.Hide();
                    }
                    else
                    {
                        this.LABEL_NOT_LOGIN_INFO.Text = USERNAME_OR_PASSWORD_FALSE;
                        this.LABEL_NOT_LOGIN_INFO.Visible = true;
                        this.TEXT_PASSWORD.Text = "Şifre";
                        this.TEXT_PASSWORD.PasswordChar = '\0';
                    }
                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message.ToString());
                }
            }
            else
            {
                this.LABEL_NOT_LOGIN_INFO.Text = USERNAME_OR_PASSWORD_NULL;
                this.LABEL_NOT_LOGIN_INFO.Visible = true;
            }
        }

        private void Enter_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void label_sifremiunttum_Click(object sender, EventArgs e)
        {
            ForgetPassword Fp = new ForgetPassword();
            Fp.ShowDialog();
        }
    }
}
