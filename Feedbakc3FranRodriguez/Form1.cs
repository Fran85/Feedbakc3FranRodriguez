using IronPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbakc3FranRodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaArchivoPDF = "D:\\FTPzilla\\Cronicasdelamarca.pdf";

            try
            {
                // Abre el archivo PDF utilizando el visor de PDF predeterminado del sistema
                System.Diagnostics.Process.Start(rutaArchivoPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message);
            }
        }
    }
}
