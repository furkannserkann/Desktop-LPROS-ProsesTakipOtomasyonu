using LPROS.Custom;
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

        SqlConnector Scon = new SqlConnector();

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
            //Form1 f1 = new LPROS.Form1();
            //f1.Show();
            //this.Hide();



            String USER_NAME = this.TEXT_USERNAME.Text.ToString();
            String PASSWORD = this.TEXT_PASSWORD.Text.ToString();

            if (USER_NAME != "Kullanıcı Adı" && PASSWORD != "Şifre")
            {
                SqlCommand SC_USERNAME_PASSWORD = new SqlCommand("Select * From Personel Where kullanici_adi=" +
                "@USERNAME and sifre=@PASSWORD", Scon.CON);

                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@USERNAME", USER_NAME);
                SC_USERNAME_PASSWORD.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                try
                {
                    Scon.setCON_EMPTY(true);
                    int TABLE_COUNT = Convert.ToInt32(SC_USERNAME_PASSWORD.ExecuteScalar());

                    if (TABLE_COUNT != 0)
                    {
                        Scon.setCON_EMPTY(false);
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
    }
}
