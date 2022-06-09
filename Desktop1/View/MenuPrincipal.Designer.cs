
namespace Desktop1.View
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classSheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableArrangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pcontainer = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.agregationToolStripMenuItem,
            this.classSheduleToolStripMenuItem,
            this.instructorManagementToolStripMenuItem,
            this.tableArrangementToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // agregationToolStripMenuItem
            // 
            this.agregationToolStripMenuItem.Name = "agregationToolStripMenuItem";
            this.agregationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.agregationToolStripMenuItem.Text = "Aggregation";
            this.agregationToolStripMenuItem.Click += new System.EventHandler(this.agregationToolStripMenuItem_Click);
            // 
            // classSheduleToolStripMenuItem
            // 
            this.classSheduleToolStripMenuItem.Name = "classSheduleToolStripMenuItem";
            this.classSheduleToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.classSheduleToolStripMenuItem.Text = "Class Shedule";
            this.classSheduleToolStripMenuItem.Click += new System.EventHandler(this.classSheduleToolStripMenuItem_Click);
            // 
            // instructorManagementToolStripMenuItem
            // 
            this.instructorManagementToolStripMenuItem.Name = "instructorManagementToolStripMenuItem";
            this.instructorManagementToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.instructorManagementToolStripMenuItem.Text = "Instructor management";
            this.instructorManagementToolStripMenuItem.Click += new System.EventHandler(this.instructorManagementToolStripMenuItem_Click);
            // 
            // tableArrangementToolStripMenuItem
            // 
            this.tableArrangementToolStripMenuItem.Name = "tableArrangementToolStripMenuItem";
            this.tableArrangementToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.tableArrangementToolStripMenuItem.Text = "Table Arrangement";
            this.tableArrangementToolStripMenuItem.Click += new System.EventHandler(this.tableArrangementToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Pcontainer
            // 
            this.Pcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pcontainer.Location = new System.Drawing.Point(0, 24);
            this.Pcontainer.Name = "Pcontainer";
            this.Pcontainer.Size = new System.Drawing.Size(800, 404);
            this.Pcontainer.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNombre});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtNombre
            // 
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 17);
            this.txtNombre.Text = "toolStripStatusLabel1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pcontainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classSheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableArrangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel Pcontainer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtNombre;
    }
}