using System;
using System.Windows.Forms;
using HCSoft.Util;



namespace HCSoft.POS.WinApp
{
    public partial class CmbCategoria : Form
    {

      
        public int mesa;
        public CmbCategoria()
        {
            InitializeComponent();
        }

        private void FrmTomarPedido_Load(object sender, EventArgs e)
        {

            this.txtMesa.Text = mesa.ToString();
            this.CargarComboGarzon();
            this.CargarComboCategoria();
        }


        protected void CargarComboGarzon()
        {

            try
            {
                this.CmbGarzon.DataSource = new HCSoft.POS.Negocio.Personal().Listar();
                this.CmbGarzon.DisplayMember = "persona";
                this.CmbGarzon.ValueMember = "idpersonal";
            }
            catch (Exception)
            {
                
                throw;
            }
        
        
        }


        protected void CargarComboCategoria()
        {
            try
            {
                this.cmb_Categoria.DataSource = new Categorias().Listar();
                this.cmb_Categoria.DisplayMember = "nombre";
                this.cmb_Categoria.ValueMember = "id";

                this.CargarProductos(Int32.Parse(this.cmb_Categoria.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
               new Log(Global.log).GuardaError("", ex);
               MessageBox.Show("se ha provocado un error al cargar la grilla de proveedores");
              
            }
        
        
        }


        protected void CargarProductos(int idcategoria)
        {
            try
            {
                this.DataGridProductos.AutoGenerateColumns = false;
               /* this.DataGridProductos.DataSource = new Productos().listarPorCategoria(idcategoria);*/
               
            }
            catch (Exception ex)
            {
              new Log(Global.log).GuardaError("", ex);   
            }
        
        
        }

        private void cmb_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_Categoria_Click(object sender, EventArgs e)
        {
            CargarProductos(Int32.Parse(this.cmb_Categoria.SelectedValue.ToString()));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridPropuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                int id = Int32.Parse(this.DataGridProductos.Rows[e.RowIndex].Cells[3].Value.ToString());
                SeleccionarProducto(id);
            
            
            }
        }
        protected void SeleccionarProducto( int id)
        {

            this.GridProductos.AutoGenerateColumns = false;
           /* ObjProducto producto =new Productos().TraerPorId(id);*/
            /*this.GridProductos.Rows.Add(producto.Id, producto.Nombre, producto.ValorVenta); // new HCSoft.POS.Negocio.Productos().TraerPorId(id).Rows[0];
    */      
    CalculaTotal();
        }

        protected void CalculaTotal()
        {
            int total = 0;
            foreach(DataGridViewRow dr in this.GridProductos.Rows)
            {
                if (dr.Cells[2].Value != null)
                {
                    total = total +  Int32.Parse(dr.Cells[2].Value.ToString());
                }
            }

            this.lblTotal.Text = total.ToString("N0");
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int idpersonal = Int32.Parse(this.CmbGarzon.SelectedValue.ToString());
            int idmesa = Int32.Parse(this.txtMesa.Text);
            string referencia = this.txtReferencia.Text;
            if (new HCSoft.POS.Negocio.Pedido().CrearPedido(idpersonal, referencia, idmesa) == true)
            {

                MessageBox.Show("Pedido Tomado, voz velaaa");            
            }


        }
    }
}
