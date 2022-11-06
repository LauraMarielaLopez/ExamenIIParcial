using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void listaDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposForm tiposForm = new TiposForm();
            tiposForm.Show();   
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }
    }
}
