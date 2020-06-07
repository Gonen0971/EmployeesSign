using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public static class DataGridStyle
    {

        public static void DataGridDesign(DataGridView dataGrid)
        {
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 53, 65);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        public static void DataGridSort(DataGridView dataGrid, string formName)
        {
            if (formName == "AddGroup")
            {
                dataGrid.Columns["GType"].SortMode = DataGridViewColumnSortMode.Automatic;
                dataGrid.Columns["GName"].SortMode = DataGridViewColumnSortMode.Automatic;
                
            }
            
        }


    }
}
