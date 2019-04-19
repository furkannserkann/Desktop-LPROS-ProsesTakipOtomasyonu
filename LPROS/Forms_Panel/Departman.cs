using LPROS.Custom;
using LPROS.Custom.ItemControl;
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
    public partial class Departman : Form
    {
        public Departman()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        String SelectedDepartmanID = "1";

        private void Departman_Load(object sender, EventArgs e)
        {
            Items.panelDepartman = new PanelGridViewTwo
            {
                form = this,
                dataGridUst = datagridview_departman,
                dataGridAlt = datagridview_personel
            };


            //Sc.LoadTable(SqlConnector.TableDepartman, datagridview_departman, Sc);
            datagridview_departman.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);

            datagridview_departman.Columns[0].Visible = false;
            if (datagridview_departman.RowCount > 0)
            {
                SelectedDepartmanID = datagridview_departman.Rows[0].Cells[0].Value.ToString();
                datagridview_personel.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonelFilterByDepartmanid, new String[] { SelectedDepartmanID });
                datagridview_personel.Columns[0].Visible = false;
                label_personel_grid_head.Text = datagridview_departman.Rows[0].Cells[1].Value.ToString() + " Departmanında Çalışan Personeller";
            }
        }

        private void datagridview_departman_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (SelectedDepartmanID != datagridview_departman.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    SelectedDepartmanID = datagridview_departman.Rows[e.RowIndex].Cells[0].Value.ToString();
                    datagridview_personel.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonelFilterByDepartmanid, new String[] { SelectedDepartmanID });
                    datagridview_personel.Columns[0].Visible = false;

                    if (itemDepartmanControl.PersonelIsim != null)
                        itemDepartmanControl.PersonelIsim.Text = "";

                    if (itemDepartmanControl.PersonelSoyisim != null)
                        itemDepartmanControl.PersonelSoyisim.Text = "";

                    if (itemDepartmanControl.PersonelDurum != null)
                        if (itemDepartmanControl.PersonelDurum.Items.Count > -1)
                            itemDepartmanControl.PersonelDurum.SelectedIndex = 0;

                    if (itemDepartmanControl.PerosnelYetki != null)
                        if (itemDepartmanControl.PerosnelYetki.Items.Count > -1)
                            itemDepartmanControl.PerosnelYetki.SelectedIndex = 0;

                    label_personel_grid_head.Text = datagridview_departman.Rows[e.RowIndex].Cells[1].Value.ToString() + " Departmanında Çalışan Personeller";
                }
            }
        }
    }
}
