using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenamiento_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string [] Nombre = new string [] {txtNombre.Text};

            string[] Edad = new string[] { txtEdad .Text };


            foreach (var item in Nombre )
            {
                foreach (var itemE in Edad)
                {
                    cmbEstudiante.Items.Add(item +"-"+itemE);

                }
            }






            
        }

        

        private void brnAsc_Click(object sender, EventArgs e)
        {
            cmbEstudiante.Sorted = true;

         
        }
    }
}
