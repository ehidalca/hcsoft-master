using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace HCSoft.Util
{
  


    public class UI
    {



        public bool ConfirmaEliminacion(DataGridView grilla, string nombreRegistro)
        {
            try
            {
                if (grilla.SelectedRows != null)
                {
                 
                    string registro = grilla.SelectedRows[0].Cells[nombreRegistro].Value.ToString();

                    int categoriaId = Int32.Parse(grilla.SelectedRows[0].Cells["id"].Value.ToString());
                    DialogResult dr = MessageBox.Show("¿ Desea Eliminar el Registro: " + registro + "?", "Confirmación Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un objeto de la Lista", "Información",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void CargarCombo(DataTable dtDatos, ComboBox combo)
        {

            List<HCSoft.Util.Item> lista = new List<HCSoft.Util.Item>();
            lista.Add(new Util.Item("Seleccionar", "-"));
            try
            {
                foreach (DataRow dr in dtDatos.Rows)
                {

                    lista.Add(new Util.Item(dr["nombre"].ToString(), dr["id"].ToString()));
                }

                combo.DataSource = lista;
                combo.DisplayMember = "Name";
                combo.ValueMember = "Value";
            }


            catch (Exception)
            {

                throw;
            }

        }

        public void CargarCombov2(ComboBox combo, DataTable dt, string nombre, string id) {
            try
            {
                
                combo.DisplayMember = nombre;
                combo.ValueMember = id;
                DataRow row = dt.NewRow();
                row[nombre] = "[Seleccionar]";
                row[id] = 0;
                dt.Rows.InsertAt(row, 0);
                combo.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
    }

