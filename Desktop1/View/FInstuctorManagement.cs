using Desktop1.Controls;
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
    public partial class FInstuctorManagement : Form
    {
        public FInstuctorManagement()
        {
            InitializeComponent();
            FillInstructor();
            FillStudent();
            FillSubject();
        }
        private void FillSubject()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                var list = model.Subjects.ToList();

                list.Insert(0, new Subject
                {

                    Name = "All"
                });

                cmbSubject.DataSource = list;
                cmbSubject.DisplayMember = "Name";
                cmbSubject.ValueMember = "ID";


            }
        }
        private void FillStudent()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                var list = model.Students.ToList().Select(x => new {
                    ID = x.ID,
                    FullName = $"{x.FirstName} {x.LastName}"

                }).ToList();
                list.Insert(0, new
                {
                    ID = (long)0,
                    FullName = $"All"

                });
                cmbStudent.DataSource = list;
                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "ID";


            }
        }

        private void FillInstructor()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                Finstructor.Controls.Clear();
                var list = model.Instructors.ToList();
                foreach (var item in list)
                {
                    Finstructor.Controls.Add(new ctrlInstructor(item) { 
                    
                    Margin = new Padding(10)
                    
                    });
                }


            }
        }
        private void FInstuctorManagement_Load(object sender, EventArgs e)
        {

        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInstructor();
        }
    }
}
