using Desktop1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop1.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Exit this program?","Alert",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        public void AbrirForm(Form form)
        {
            Pcontainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            Pcontainer.Controls.Add(form);
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if(Util.Instructor is default(Instructor))
            {
                txtNombre.Text = "Guess";
            }else
            {
                txtNombre.Text = $"{Util.Instructor.FirstName} {Util.Instructor.LastName}";
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FInvoice());
        }

        private void agregationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FAggregation());
        }

        private void classSheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FShedule());
        }

        private void instructorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FInstuctorManagement());
        }

        private void tableArrangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FTableArrangement());
        }
    }
}
