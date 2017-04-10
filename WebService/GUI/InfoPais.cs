using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebService.BO;

namespace WebService.GUI
{
    public partial class InfoPais : Form
    {
        
        LogicaBO log;
        public InfoPais()
        {
            InitializeComponent();
        }

        private void bttConsultar_Click(object sender, EventArgs e)
        {

            listResut.Items.Clear(); //Elimina los items del ListB
            List<String> datos = log.ConsultarPais(txtPais.Text);
                if (datos != null)
                {
                  listResut.Items.Add("    "+txtPais.Text);
                foreach (string item in datos)
                    {
                        listResut.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Digite un Nombre de País Valido!!!");
                }
                
                txtPais.Text = ""; //limpia txtPais
              
            
            
        }

        private void InfoPais_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            log = new LogicaBO();
        }
    }
}
