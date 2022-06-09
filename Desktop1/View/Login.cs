using Desktop1.Model;
using Desktop1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Desktop1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();



            lblCapchat.Text = Guid.NewGuid().ToString().Substring(0, 6);
            lblCapchat.CreateGraphics().DrawLine(new Pen(Color.Red, 2) { }, new Point(0, 0), new Point(40, 40));
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblCapchat.Text = Guid.NewGuid().ToString().Substring(0, 6);
            lblCapchat.CreateGraphics().DrawLine(new Pen(Color.Red,2) { }, new Point(0, 0), new Point(10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "";
            
            if (lblCapchat.Text != txtRecaptcha.Text)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Recaptcha invalid, try again";
                return;
            }

            using(Desktop1Entities model = new Desktop1Entities())
            {
                Instructor instructor = model.Instructors.FirstOrDefault(x => x.UserName.ToLower() == txtUserName.Text.ToLower() && x.Password == txtPassword.Text);
                if (instructor is default(Instructor))
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Username or password incorrect";
                    return;
                }

                Util.Instructor = instructor;
                this.Hide();
                if(new MenuPrincipal().ShowDialog() != DialogResult.Abort)
                {
                    this.Show();
                    this.txtPassword.Text = txtRecaptcha.Text = txtUserName.Text = String.Empty;
                }
            
    
            }
        }

        private void cbSee_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbSee.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.Instructor = null ;
            this.Hide();
            if (new MenuPrincipal() { 
            
                
            }.ShowDialog() != DialogResult.Abort)
            {
                this.Show();
                this.txtPassword.Text = txtRecaptcha.Text = txtUserName.Text = String.Empty;
            }
        }
    }
}
