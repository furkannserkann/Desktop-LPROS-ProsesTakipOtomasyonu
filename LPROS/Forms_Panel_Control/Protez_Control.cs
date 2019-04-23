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
    public partial class Protez_Control : Form
    {
        public Protez_Control()
        {
            InitializeComponent();
        }

        private void Protez_Control_Load(object sender, EventArgs e)
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

        private void button_protez_ekle_Click(object sender, EventArgs e)
        {
            Add_Protez addProtez = new Add_Protez()
            {
                isUpdate = false
            };
            addProtez.ShowDialog();
        }

        private void button_protez_guncelle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProtez.dataGridUst;

            Add_Protez addProtez = new Add_Protez()
            {
                isUpdate = true,
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Id"].Value.ToString(),
                _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Kod"].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["İsim"].Value.ToString()
            };
            addProtez.ShowDialog();
        }

        SqlConnector Sc = new SqlConnector();
        private void button_protez_sil_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelProtez.dataGridUst;
            string selectId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString();

            DialogResult Dr = MessageBox.Show("Seçilen Proses Siliniyor!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                if (Sc.QUERY_TABLE("update Protez set durum=0 where id=@parametre1", new String[] { selectId }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Items.panelProtez.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);
                    if (Items.panelProtez.dataGridUst.Rows.Count > 0)
                    {
                        Protezler.SelectedProtezid = Items.panelProtez.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProtez.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimatByProtezid, new String[] { Protezler.SelectedProtezid });
                        Items.panelProtez.dataGridAlt.Columns[0].Visible = false;
                    }
                }
            }
        }
    }
}
