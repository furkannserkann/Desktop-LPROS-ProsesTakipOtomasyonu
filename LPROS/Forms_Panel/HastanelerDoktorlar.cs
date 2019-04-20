using LPROS.Custom;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Update;
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

namespace LPROS.Forms_Panel
{
    public partial class HastanelerDoktorlar : Form
    {
        public HastanelerDoktorlar()
        {
            InitializeComponent();
        }

        String SelectedHastaneID = "1";
        SqlConnector Sc = new SqlConnector();

        private void HastanelerDoktorlar_Load(object sender, EventArgs e)
        {
            Items.panelHastaneDoktor = new PanelGridViewTwo
            {
                form = this,
                dataGridUst = datagridview_hastane,
                dataGridAlt = datagridview_doktor
            };

            datagridview_hastane.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
            datagridview_hastane.Columns[1].Visible = false;
            if (datagridview_hastane.RowCount > 0)
            {
                SelectedHastaneID = datagridview_hastane.Rows[0].Cells[1].Value.ToString();
                datagridview_doktor.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new String[] { SelectedHastaneID });
                datagridview_doktor.Columns[1].Visible = false;
            }
        }

        private void datagridview_hastane_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (SelectedHastaneID != datagridview_hastane.Rows[e.RowIndex].Cells[1].Value.ToString())
                {
                    SelectedHastaneID = datagridview_hastane.Rows[e.RowIndex].Cells[1].Value.ToString();
                    datagridview_doktor.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new String[] { SelectedHastaneID });
                    datagridview_doktor.Columns[1].Visible = false;
                }
            }
        }

        private void datagridview_hastane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            

            if (e.ColumnIndex == senderGrid.Columns["update"].Index && e.RowIndex >= 0)
            {
                DataGridView Dtg = Items.panelHastaneDoktor.dataGridUst;
                Add_Hastane addHastane = new Add_Hastane()
                {
                    isUpdate = true,
                    _Select_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["ID"].Value.ToString(),
                    _Select_kod = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Kod"].Value.ToString(),
                    _Select_ad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Adı"].Value.ToString(),
                    _Select_adres = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Adres"].Value.ToString()
                };

                addHastane.ShowDialog();
            }
        }

        private void datagridview_doktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            DataGridView Dtg2 = Items.panelHastaneDoktor.dataGridUst;
            DataGridView Dtg = Items.panelHastaneDoktor.dataGridAlt;

            if (e.ColumnIndex == senderGrid.Columns["duzenle"].Index && e.RowIndex >= 0)
            {
                Add_Doktor addDoktor = new Add_Doktor()
                {
                    isUpdate = true,
                    _Select_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["ID"].Value.ToString(),
                    _Select_ad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["İsim"].Value.ToString(),
                    _Select_soyad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Soyisim"].Value.ToString(),
                    _Select_hastane_id = Dtg2.Rows[Dtg2.CurrentCell.RowIndex].Cells["ID"].Value.ToString(),
                    _selected_durum = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Durumu"].Value.ToString(),

                };

                addDoktor.ShowDialog();
            }
        }
    }
}
