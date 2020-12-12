using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace HCSoft
{
    public class Mensajes
    {
        public void Eliminado()
        {
            MessageBox.Show("Registro Eliminado", "Confirmación",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Actualizado()
        {
            MessageBox.Show("Registro Actyualizado", "Confirmación",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Ingresado()
        {
            MessageBox.Show("Registro Actyualizado", "Confirmación",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Error(Exception error)
        {
            MessageBox.Show("Se ha probocado un error: " + error.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}


