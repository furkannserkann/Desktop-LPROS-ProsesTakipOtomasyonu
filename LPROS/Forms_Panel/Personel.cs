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

namespace LPROS.Forms_Panel
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Personel_Load(object sender, EventArgs e)
        {
            Items.panelPersonel = new PanelGridView
            {
                form = this,
                dataGridview = datagridview_personel
            };


            datagridview_personel.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel);
            datagridview_personel.Columns[1].Visible = false;
            datagridview_personel.Columns["sifre"].Visible = false;
        }

        private void datagridview_personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ayrinti"].Index && e.RowIndex >= 0)
            {
                (new Info_Personel()).ShowDialog();
            }
        }
    }
}
