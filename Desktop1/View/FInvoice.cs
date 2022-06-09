using Desktop1.Model;
using Desktop1.ViewClass;
using Microsoft.Office.Interop.Excel;
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
    public partial class FInvoice : Form
    {
        public FInvoice()
        {
            InitializeComponent();
            FillStudent();
            FillSubject();
            FillInvoce();
        }

        private void FillStudent()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                var list = model.Students.ToList().Select(x=> new { 
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

        private void FillSubject()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                var list = model.Subjects.ToList();

                list.Insert(0, new Subject {
                
                Name = "All"
                });

               cmbSubject.DataSource = list;
                cmbSubject.DisplayMember = "Name";
                cmbSubject.ValueMember = "ID";


            }
        }

        private void FillInvoce()
        {
            using (Desktop1Entities model = new Desktop1Entities())
            {
                List<InvoiceView> invoiceViews = new List<InvoiceView>();

                foreach (var student in model.Students.ToList())
                {
                    foreach (var item in student.ClassApplications.ToList())
                    {
                        if(item.Invoices.Count(x=> !x.Confirmed)> 0)
                        {
                            invoiceViews.Add(new InvoiceView { 
                            Student = $"{student.FirstName } {student.LastName}",
                            Class = item.Class.Title,
                            ID = item.ID,
                            Price =(double) item.Invoices.Sum(x=> x.Price),
                            Subject = item.Class.Subject.Name,
                            Deadline = item.Class.Date
                            
                           
                            
                            });
                        }
                    }
                }
                dataGridView1.DataSource = invoiceViews.OrderByDescending(x=> x.Deadline).ToList();
            }
        }
        private void FInvoice_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
               
               
            }
        }
    }
}
