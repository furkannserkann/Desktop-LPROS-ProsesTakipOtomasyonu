using LPROS.Custom;
using LPROS.Forms.Table.Info;
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

namespace LPROS.Panel_Forms
{
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Siparis_Load(object sender, EventArgs e)
        {
            Items.panelSiparis = new PanelGridView
            {
                form = this,
                dataGridview = datagridview_Siparis
            };

            datagridview_Siparis.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis);
            datagridview_Siparis.Columns[1].Visible = false;
        }

        private void datagridview_Siparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ayrinti"].Index && e.RowIndex >= 0)
            {
                Info_Siparis infSiparis = new Info_Siparis()
                {
                    siparisid = datagridview_Siparis.Rows[e.RowIndex].Cells["id"].Value.ToString()
                };
                infSiparis.ShowDialog();
            }
        }
    }
}
