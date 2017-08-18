using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceOwncloud.Service1Client servicio = new ServiceOwncloud.Service1Client();
            ServiceOwncloud.oc_users datos = new ServiceOwncloud.oc_users();

            datos.uid = textBox1.Text;
            datos.displayname = "";
            datos.password = textBox2.Text;
            ServiceOwncloud.oc_users band = servicio.create(datos);
            if (band != null )
            {
                MessageBox.Show("Agregado correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceOwncloud.Service1Client servicio = new ServiceOwncloud.Service1Client();
            ServiceOwncloud.oc_users datos = new ServiceOwncloud.oc_users();

            datos.uid = textBox3.Text;
            datos.displayname = "";
            datos.password = textBox4.Text;
            ServiceOwncloud.oc_users band = servicio.update(datos);
            if (band != null)
            {
                MessageBox.Show("Modificado correctamente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceOwncloud.Service1Client servicio = new ServiceOwncloud.Service1Client();
            int delete = servicio.delete(textBox5.Text);
            if(delete == 1)
            {
                MessageBox.Show("Eliminado correctamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceOwncloud.Service1Client servicio = new ServiceOwncloud.Service1Client();
            IEnumerable<ServiceOwncloud.oc_users> list = servicio.list();
            MessageBox.Show(""+ list.Count());
            string lista = "";
            foreach(var item in list)
                {
                    lista += item.uid + " - ";
                }
            textBox6.Text = lista;
        }
    }
}
