using LPROS.Custom;
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

namespace LPROS.Forms_Panel
{
    public partial class YetkiRenk : Form
    {
        public YetkiRenk()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void YetkiRenk_Load(object sender, EventArgs e)
        {
            Items.panelYetkiRenk = new PanelGridViewTwo
            {
                form = this,
                //dataGridUst = datagridview_yetki,
                dataGridAlt = datagridview_renk
            };

            //datagridview_yetki.DataSource = Sc.GET_DATATABLE(SqlConnector.TableYetki);
            //datagridview_yetki.Columns[1].Visible = false;

            datagridview_renk.DataSource = Sc.GET_DATATABLE(SqlConnector.TableRenk);
            datagridview_renk.Columns[0].Visible = false;
        }

        private void datagridview_renk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["update2"].Index && e.RowIndex >= 0)
            {
                (new Update_Renk()).ShowDialog();
            }
        }

        private void datagridview_yetki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["update1"].Index && e.RowIndex >= 0)
            {
                (new Update_Yetki()).ShowDialog();
            }
        }
    }
}
