using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Custom
{
    class MySetting
    {
        public static Boolean isOpenRapor { get; set; }

        public static Form FormRapor { get; set; }

        public static Boolean isOpenBarkod { get; set; }

        public static Form FormBarkod { get; set; }

        public static void loadComboboxDataTable(ComboBox combobox, DataTable datatable, string idcolumnName, string isimcolumnName)
        {
            DataRow emptyRow = datatable.NewRow();
            emptyRow[idcolumnName] = 0;
            emptyRow[isimcolumnName] = "";
            datatable.Rows.Add(emptyRow);

            DataView newView = new DataView(datatable, "", isimcolumnName, DataViewRowState.CurrentRows);

            combobox.DataSource = newView;
            combobox.DisplayMember = isimcolumnName;
            combobox.ValueMember = idcolumnName;
        }

    }
}
