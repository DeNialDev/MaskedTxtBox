using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTxtBx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DynamicMskedTxtBox();
        }
        //Creación en tiempo de Ejecución 
        private void DynamicMskedTxtBox()
        {
            //Instancia
            MaskedTextBox MSk = new MaskedTextBox();
            //Posición
            MSk.Location = new Point(26, 135);
            //Nombre
            MSk.Name = "DynamicMaskedTextBox";
            string name = MSk.Name;
            //Mascara o formato del texto que tenemos que ingresar
            MSk.Mask = "00/00/0000";
            Controls.Add(MSk);
        }

        private void btnCambiarFecha_Click(object sender, EventArgs e)
        {

            if (mskTxtFecha.Text.Length == 2)
            {
                MessageBox.Show("Ingrese una fecha");
            }
            else
            {
                lblFecha.Text = mskTxtFecha.Text;
            }
           
        }
    }
}
