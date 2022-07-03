using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

//namespace winformproductos1
//{
    //public partial class Formproductos : Form
    //{
        //private int stock;
        //private int cant;
        //Producto NuevoProd;
        //Producto ProdExistente;
        //bool nuevo = true;
        //int fila;



        /*public Formproductos()
        {
            InitializeComponent();
            dgprod.Columns.Add("0", "Código");
            dgprod.Columns.Add("1", "Descripción");
            dgprod.Columns.Add("2", "Stock");
            dgprod.Columns[0].Width = 100;
            dgprod.Columns[1].Width = 300;
            dgprod.Columns[2].Width = 60;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            var nuevoprod = new Producto(int.Parse(txtcodigo.Text), txtdescrip.Text);
            lblcodmov.Text = nuevoprod.propcodigo.ToString();

            lbldescripmov.Text = nuevoprod.propdescrip.ToString();
            lblstockmov.Text = " tiene " + nuevoprod.propstock.ToString() + " unidades";
            MessageBox.Show("producto instanciado");
            //tabC_Productos.SelectedTab = tabP_Movimiento;
            txtcodigo.Clear();
            txtcodigo.Focus();
            //LlevarProdAldgv(NuevoProd);
            //nuevo = true;
            // metodo llevar prod al dgv
            /*void LlevarProdAldgv(Producto Prod)
            {
                dgprod.Rows.Add(Prod.propcodigo.ToString(), Prod.propdescrip,
                Prod.propstock.ToString());
                fila = (dgprod.Rows.Count - 1);
            }
            //codigo.Rows.Add();
            //codigo[0, 0].value = txtcodigo.Text;
            //descripcion[1, 0].value = txtdescrip.Text;
            //cantidad[2, 0].value = txtstock.Text;
            //private DataTable Dt { get; set; } = new DataTable { };







        }

        private void LlevarProdAldgv(Producto nuevoProd, int fila)
        {
            throw new NotImplementedException();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //private void btncarg2_Click(object sender, EventArgs e)
        //{
            //if (nuevo == true)
            //{
               /* if (rbegreso.Checked == true)
                {
                    NuevoProd.ingreso(int.Parse(lblstockmov.Text));
                }
                if (rbegreso.Checked == true)
                {
                    NuevoProd.salida(int.Parse(lblstockmov.Text));
                }
                LlevarProdAldgv(NuevoProd, fila);
            }
            else
            {
                if (rbegreso.Checked == true)
                {
                    ProdExistente.ingreso(int.Parse(lblstockmov.Text));
                }
                if (rbegreso.Checked == true)
                {
                    ProdExistente.salida(int.Parse(lblstockmov.Text));
                }
                LlevarProdAldgv(ProdExistente, fila);

            }

            //private void rbingreso_CheckedChanged(object sender, EventArgs e)
            //{

            // }

            //private void txtcant_TextChanged(object sender, EventArgs e)
            //{

            */
        //}
    //}
//}