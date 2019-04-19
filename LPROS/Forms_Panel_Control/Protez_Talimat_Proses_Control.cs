using LPROS.Custom;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Info;
using LPROS.Forms.Table.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms_Panel_Control
{
    public partial class Protez_Talimat_Proses_Control : Form
    {
        public Protez_Talimat_Proses_Control()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Protez_Talimat_Proses_Control_Load(object sender, EventArgs e)
        {
            groupBox1.Paint += PaintBorderlessGroupBox1;
            groupBox2.Paint += PaintBorderlessGroupBox2;
            groupBox3.Paint += PaintBorderlessGroupBox1;
        }

        private void PaintBorderlessGroupBox1(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 62, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void PaintBorderlessGroupBox2(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 65, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void button_ekleprotez_Click(object sender, EventArgs e)
        {
            (new Add_Protez()).ShowDialog();
        }

        private void button_ekltalimat_Click(object sender, EventArgs e)
        {
            (new Add_Talimat()).ShowDialog();
        }

        private void button_button_ekleproses_Click(object sender, EventArgs e)
        {
            (new Add_Proses()).ShowDialog();
        }

        private void button_guncelle_proses_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProtezTalimatProses.datagridProses;
            Update_Proses Up = new Update_Proses()
            {
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[2].Value.ToString()
            };
            Up.ShowDialog();
        }

        private void button_proses_sil_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Proses Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = Items.panelProtezTalimatProses.datagridProses;

                if (Sc.QUERY_TABLE("delete from Proses where Id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProtezTalimatProses.datagridProses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                }
            }
        }

        private void textbox_ara_kod_TextChanged(object sender, EventArgs e)
        {
                SearchProses();
        }

        private void textbox_ara_isim_TextChanged(object sender, EventArgs e)
        {
                SearchProses();
        }

        private void button_temizle_isim_Click_1(object sender, EventArgs e)
        {
            _SearchProsesClear = true;
            SearchProses();
        }

        private bool _SearchProsesClear = false;
        private void SearchProses()
        {
            if (!_SearchProsesClear)
            {
                String _Kod = textbox_ara_kod.Text;
                String _Isim = textbox_ara_isim.Text;
                Items.panelProtezTalimatProses.datagridProses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses + " Where kod like '%'+@parametre1+'%' and isim like '%'+@parametre2+'%'", new String[] { _Kod, _Isim });
            }
            else
            {
                if (textbox_ara_kod.Text != "" || textbox_ara_isim.Text != "")
                {
                    textbox_ara_kod.Text = "";
                    textbox_ara_isim.Text = "";

                    Items.panelProtezTalimatProses.datagridProses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                    _SearchProsesClear = false;
                }
            }
        }

        private void button_guncelle_talimat_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProtezTalimatProses.datagridTalimat;
            Update_Talimat Up = new Update_Talimat()
            {
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                _SelectedAciklama = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[3].Value.ToString(),
            };
            Up.ShowDialog();
        }

        private void button_detay_talimat_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProtezTalimatProses.datagridTalimat;
            Info_Talimat IT = new Info_Talimat()
            {
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                _SelectedAciklama = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[3].Value.ToString(),
            };
            IT.ShowDialog();
        }

        private void button_sil_talimat_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Talimat Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = Items.panelProtezTalimatProses.datagridTalimat;

                if (Sc.QUERY_TABLE("delete from Talimat where Id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() }))
                {
                    Sc.QUERY_TABLE("delete from Talimat_Prosesleri where talimat_id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() });

                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProtezTalimatProses.datagridTalimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                }
            }
        }

        private void textbox_kod_talimat_TextChanged(object sender, EventArgs e)
        {
            SearchTalimat();
        }


        private bool _SearchTalimatClear = false;
        private void SearchTalimat()
        {
            if (!_SearchTalimatClear)
            {
                String _Kod = textbox_kod_talimat.Text;
                String _Isim = textbox_isim_talimat.Text;
                Items.panelProtezTalimatProses.datagridTalimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat + " Where talimat_kodu like '%'+@parametre1+'%' and talimat_adi like '%'+@parametre2+'%' order by talimat_kodu asc", new String[] { _Kod, _Isim });
            }
            else
            {
                if (textbox_kod_talimat.Text != "" || textbox_isim_talimat.Text != "")
                {
                    textbox_kod_talimat.Text = "";
                    textbox_isim_talimat.Text = "";

                    Items.panelProtezTalimatProses.datagridTalimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat + " order by talimat_kodu asc");
                    _SearchTalimatClear = false;
                }
            }
        }

        private void button_temizle_talimat_Click(object sender, EventArgs e)
        {
            _SearchTalimatClear = true;
            SearchTalimat();
        }
    }
}
