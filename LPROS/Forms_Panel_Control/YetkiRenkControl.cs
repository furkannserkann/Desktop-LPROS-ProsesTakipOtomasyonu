using LPROS.Custom;
using LPROS.Forms.Table.Add;
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
    public partial class YetkiRenkControl : Form
    {
        public YetkiRenkControl()
        {
            InitializeComponent();
        }

        private void YetkiRenkControl_Load(object sender, EventArgs e)
        {

        }

        private void button_eklerenk_Click(object sender, EventArgs e)
        {
            Add_Renk addRenk = new Add_Renk()
            {
                isUpdate = false
            };
            addRenk.ShowDialog();
        }

        private void button_renk_guncelle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelYetkiRenk.dataGridview;
            if (Dtg.Rows.Count > 0)
            {
                Add_Renk addRenk = new Add_Renk()
                {
                    isUpdate = true,
                    _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["İsim"].Value.ToString(),
                    _SelectedKod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Renk Kodu"].Value.ToString(),
                    _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString()
                };

                addRenk.ShowDialog();
            }
        }

        SqlConnector Sc = new SqlConnector();
        private void button5_Click(object sender, EventArgs e)
        {
            if (Items.panelYetkiRenk.dataGridview.Rows.Count > 0)
            {
                DialogResult Dr = MessageBox.Show("Seçilen Renk Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Dr == DialogResult.OK)
                {
                    DataGridView Dtg = Items.panelYetkiRenk.dataGridview;

                    if (Sc.QUERY_TABLE("Update Renk set durum=0 where id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() }))
                    {
                        MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Items.panelYetkiRenk.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableRenk);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchRenk();
        }
        private void searchRenk()
        {
            DataGridView Dtg = Items.panelYetkiRenk.dataGridview;
    
            Items.panelYetkiRenk.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableRenk + " where kod like '%'+@parametre1+'%' and isim like '%'+@parametre2+'%'  ", new String[] { Renkkod.Text, Renkismi.Text });

            Items.panelYetkiRenk.dataGridview.Columns[0].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renkkod.Text = "";
            Renkismi.Text = "";
            searchRenk();
        }
    }
}
