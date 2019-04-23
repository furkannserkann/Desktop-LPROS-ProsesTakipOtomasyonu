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
    public partial class Proses_Control : Form
    {
        public Proses_Control()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Proses_Control_Load(object sender, EventArgs e)
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

        private void button_proses_ekle_Click(object sender, EventArgs e)
        {
            Add_Proses addProses = new Add_Proses()
            {
                isUpdate = false
            };
            addProses.ShowDialog();
        }

        private void button_proses_guncelle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProses.dataGridUst;

            if (Dtg.Rows.Count > 0)
            {
                Add_Proses addProses = new Add_Proses()
                {
                    isUpdate = true,
                    _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Id"].Value.ToString(),
                    _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Kod"].Value.ToString(),
                    _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["İsim"].Value.ToString(),
                };
                addProses.ShowDialog();
            }
        }

        private void button_proses_sil_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProses.dataGridUst;

            if (Dtg.Rows.Count > 0)
            {
                string selectId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                DialogResult Dr = MessageBox.Show("Seçilen Proses Siliniyor!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Dr == DialogResult.OK)
                {
                    if (Sc.QUERY_TABLE("Update Proses set durum=0 where id=@parametre1", new String[] { selectId }))
                    {
                        MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Items.panelProses.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                        if (Items.panelProses.dataGridUst.Rows.Count > 0)
                        {
                            Prosesler.SelectedProsesID = Items.panelProses.dataGridUst.Rows[0].Cells[0].Value.ToString();
                            Items.panelProses.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { Prosesler.SelectedProsesID });
                            Items.panelProses.dataGridAlt.Columns[0].Visible = false;
                        }
                    }
                }
            }
        }


        private bool _SearchProsesClear = false;
        private void SearchProses()
        {
            if (!_SearchProsesClear)
            {
                String _Isim = textbox_ara_isim.Text, _Kod = textbox_ara_kod.Text;
                Items.panelProses.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses + " and kod like '%'+@parametre1+'%' and isim like '%'+@parametre2+'%'", new String[] { _Kod, _Isim });

                if (Items.panelProses.dataGridUst.Rows.Count > 0)
                {
                    Prosesler.SelectedProsesID = Items.panelProses.dataGridUst.Rows[0].Cells[0].Value.ToString();
                    Items.panelProses.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { Prosesler.SelectedProsesID });
                    Items.panelProses.dataGridAlt.Columns[0].Visible = false;
                }
            }
            else
            {
                if (textbox_ara_isim.Text != "" || textbox_ara_kod.Text != "")
                {
                    textbox_ara_isim.Text = "";
                    textbox_ara_kod.Text = "";

                    Items.panelProses.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                    if (Items.panelProses.dataGridUst.Rows.Count > 0)
                    {
                        Prosesler.SelectedProsesID = Items.panelProses.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProses.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { Prosesler.SelectedProsesID });
                        Items.panelProses.dataGridAlt.Columns[0].Visible = false;
                    }

                    _SearchProsesClear = false;
                }
            }
        }

        private void textbox_ara_kod_TextChanged(object sender, EventArgs e)
        {
            SearchProses();
        }

        private void button_temizle_isim_Click(object sender, EventArgs e)
        {
            _SearchProsesClear = true;
            SearchProses();
        }
    }
}
