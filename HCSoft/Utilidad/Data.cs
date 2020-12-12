
using System.Data;
using System.Windows.Forms;

namespace HCSoft.Util
{
    public class Data
    {
        public void CargaDatosGrilla(DataTable datos, DataGridView dataGrid ) {
            try
            {
                dataGrid.AutoGenerateColumns = false;
                dataGrid.AllowUserToAddRows = false;        
                dataGrid.DataSource = datos;
                dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             

            }
            catch (System.Exception)
            {

                throw;
            }
                
        }
          
    }
}
