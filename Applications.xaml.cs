using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Assiment2
{
    public partial class Applications : Page
    {
        assiegnmentEntities db = new assiegnmentEntities();
        private string email;

        public Applications(string userEmail)
        {
            InitializeComponent();
            email = userEmail;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var rec = db.Students.FirstOrDefault(x => x.Email == email);
            if (rec != null)
            {
                rec.Names = txtname.Text;
                rec.Addres = txtaddres.Text;
                var department = db.Departments.FirstOrDefault(d => d.Names == txtdep.Text);
                if (department != null)
                {
                    rec.DepId = department.Department_Id;
                }
                rec.Age = int.Parse(txtage.Text);
                db.Students.AddOrUpdate(rec);
                db.SaveChanges();
                NavigationService?.Navigate(new Admin());
            }
            else
            {
                MessageBox.Show("You can't change data because the student was not found.");
            }
        }
    }
}
