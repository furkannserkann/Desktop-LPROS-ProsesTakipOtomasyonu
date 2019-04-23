using LPROS.Custom;
using LPROS.Forms.Table.Add;
using LPROS.Forms_Panel;
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
    public partial class Talimat_Control : Form
    {
        public Talimat_Control()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Talimat_Control_Load(object sender, EventArgs e)
        {
            groupBox3.Paint += PaintBorderlessGroupBox1;
        }

        private void PaintBorderlessGroupBox1(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 80, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void button_talimat_ekle_Click(object sender, EventArgs e)
        {
            Add_Talimat addTalimat = new Add_Talimat()
            {
                isUpdate = false
            };

            addTalimat.ShowDialog();
        }

        private void button_talimat_guncelle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelTalimat.dataGridUst;

            Add_Talimat addTalimat = new Add_Talimat()
            {
                isUpdate = true,
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Id"].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Talimat İsmi"].Value.ToString(),
                _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Talimat Kodu"].Value.ToString()
            };

            addTalimat.ShowDialog();
        }

        private void button_talimat_sil_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelTalimat.dataGridUst;
            string selectId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString();

            DialogResult Dr = MessageBox.Show("Seçilen Talimat Siliniyor!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                if (Sc.QUERY_TABLE("Update Talimat set durum=0 where id=@parametre1", new String[] { selectId }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Items.panelTalimat.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                    if (Items.panelTalimat.dataGridUst.Rows.Count > 0)
                    {
                        Talimatlar.SelectedTalimatID = Items.panelTalimat.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelTalimat.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { Talimatlar.SelectedTalimatID });
                        Items.panelTalimat.dataGridAlt.Columns[0].Visible = false;
                    }
                }
            }
        }

        private void textbox_ara_kod_TextChanged(object sender, EventArgs e)
        {
            SearchTalimat();
        }

        private bool _SearchTalimatClear = false;
        private void SearchTalimat()
        {
            if (!_SearchTalimatClear)
            {
                String _Isim = textbox_ara_isim.Text, _Kod = textbox_ara_kod.Text;
                Items.panelTalimat.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat + " Where talimat_kodu like '%'+@parametre1+'%' and talimat_adi like '%'+@parametre2+'%'", new String[] { _Kod, _Isim });

                if (Items.panelTalimat.dataGridUst.Rows.Count > 0)
                {
                    Talimatlar.SelectedTalimatID = Items.panelTalimat.dataGridUst.Rows[0].Cells[0].Value.ToString();
                    Items.panelTalimat.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { Talimatlar.SelectedTalimatID });
                    Items.panelTalimat.dataGridAlt.Columns[0].Visible = false;
                }
            }
            else
            {
                if (textbox_ara_isim.Text != "" || textbox_ara_kod.Text != "")
                {
                    textbox_ara_isim.Text = "";
                    textbox_ara_kod.Text = "";

                    Items.panelTalimat.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);

                    if (Items.panelTalimat.dataGridUst.Rows.Count > 0)
                    {
                        Talimatlar.SelectedTalimatID = Items.panelTalimat.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelTalimat.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { Talimatlar.SelectedTalimatID });
                        Items.panelTalimat.dataGridAlt.Columns[0].Visible = false;
                    }

                    _SearchTalimatClear = false;
                }
            }
        }

        private void button_temizle_isim_Click(object sender, EventArgs e)
        {
            _SearchTalimatClear = true;
            SearchTalimat();
        }
    }
}
