using LPROS.Custom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms.Table.Add
{
    public partial class Add_Talimat : Form
    {
        public Add_Talimat()
        {
            InitializeComponent();
        }

        int Nowsira = 1;
        SqlConnector Sc = new SqlConnector();
        public bool isUpdate = false;

        private void Add_Talimat_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Talimat Güncelle";
                button_talimat_kaydet.Text = "Talimat Bilgilerini Güncelle";
            }
            else
            {
                datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                datagridview_proses.Columns[2].Visible = false;
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;

                for (int i = 0; i < datagridview_proses.Columns.Count; i++)
                {
                    datagridview_proses.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            }
           
        }

        private void datagridview_proses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ekle"].Index && e.RowIndex >= 0)
            {
                
                    if ((Boolean)datagridview_proses.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                    {
                        datagridview_proses.Rows[e.RowIndex].Cells[1].Value = Nowsira.ToString();
                        Nowsira ++;
                    }
                    else
                    {
                        datagridview_proses.Rows[e.RowIndex].Cells[1].Value = "";
                    }
                
            }
        }

        private void textbox_ara_kod_TextChanged(object sender, EventArgs e)
        {
            SearchProses();
        }

        private bool _SearchProsesClear = false;
        private void SearchProses()
        {
            if (!_SearchProsesClear)
            {
                String _Kod = textbox_ara_kod.Text;
                String _Isim = textbox_ara_isim.Text;
                datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses + " Where kod like '%'+@parametre1+'%' and isim like '%'+@parametre2+'%'", new String[] { _Kod, _Isim });
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;
            }
            else
            {
                if (textbox_ara_kod.Text != "" || textbox_ara_isim.Text != "")
                {
                    textbox_ara_kod.Text = "";
                    textbox_ara_isim.Text = "";

                    datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;
                    _SearchProsesClear = false;
                }
            }
        }

        private void button_temizle_isim_Click(object sender, EventArgs e)
        {
            _SearchProsesClear = true;
            SearchProses();
        }

        private void textbox_ara_isim_TextChanged(object sender, EventArgs e)
        {
            SearchProses();
        }

        private void button_talimat_kaydet_Click(object sender, EventArgs e)
        {
            TalimatKaydet();
        }

        private void TalimatKaydet()
        {
            String kod = textbot_talimat_kod.Text, isim = textbot_talimat_isim.Text;

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Talimat Where talimat_kodu=@parametre1";
                String _QueryIsim = "select * from Talimat Where talimat_adi=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_talimat_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_talimat_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Talimat", new String[] { "talimat_kodu", "talimat_adi" }, new String[] { kod, isim  }))
                {
                    String SelectTalimatId = Sc.GET_TEKDEGER("select Id from Talimat where talimat_kodu=@parametre1", new String[] { kod });


                    for (int i = 0; i < datagridview_proses.RowCount; i++)
                    {
                        if ((Boolean)datagridview_proses.Rows[i].Cells[0].EditedFormattedValue)
                        {
                            Sc.ADD_TABLE("Talimat_Prosesleri", new String[] { "proses_id", "talimat_id", "sira" }, 
                                new String[] { (String)datagridview_proses.Rows[i].Cells[2].Value.ToString(),
                                    (String)SelectTalimatId.ToString(),
                                    datagridview_proses.Rows[i].Cells[1].Value.ToString() });
                        }
                    }

                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbot_talimat_kod.Text = "";
                    textbot_talimat_isim.Text = "";
                    textbot_talimat_kod.Focus();

                    SearchProses();

                    Items.panelProtezTalimatProses.datagridTalimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbot_talimat_kod.Text == "")
                {
                    textbot_talimat_kod.Focus();
                }
                else if (textbot_talimat_isim.Text == "")
                {
                    textbot_talimat_isim.Focus();
                }
            }
        }

        private void textbot_talimat_kod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TalimatKaydet();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
