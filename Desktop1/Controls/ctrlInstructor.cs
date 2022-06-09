using Desktop1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop1.Controls
{
    public partial class ctrlInstructor : UserControl
    {
        Instructor Instructor = null;
        public ctrlInstructor(Instructor instructor)
        {
            Instructor = instructor;
            InitializeComponent();
            lblName.Text = $"{instructor.FirstName} {instructor.LastName}";
            lblSubject.Text = "";
            foreach (var item in instructor.TeachableSubjects.ToList())
            {
                lblSubject.Text += $"{item.Subject.Name},";
            }
            pictureBox1.Image = Image.FromStream(new MemoryStream(instructor.Photo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    var a = new MemoryStream();
                    pictureBox1.Image.Save(a, ImageFormat.Png);
                      
                    Instructor.Photo = a.ToArray();
                    using (Desktop1Entities model = new Desktop1Entities())
                    {
                        Instructor instructor_ = model.Instructors.FirstOrDefault(x => x.ID == Instructor.ID);
                        instructor_.Photo = Instructor.Photo;
                        model.Entry(instructor_).State = System.Data.Entity.EntityState.Modified;
                        if(model.SaveChanges()> 0)
                        {
                            MessageBox.Show("Successfull");
                        }else
                        {
                            MessageBox.Show("Error, try again");
                        }


                    }
                }
                catch (Exception er)
                {

                    MessageBox.Show("Error, compruebe que sea una imagen");
                }
              
            }
        }
    }
}
