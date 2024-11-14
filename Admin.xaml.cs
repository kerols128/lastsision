using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Assiment2
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        assiegnmentEntities db = new assiegnmentEntities();

        public Admin()
        {
            InitializeComponent();
            var rec = db.Students.Select(x => new
            {
                x.ID,
                Name = x.Names,
                Address = x.Addres,
                Age = x.Age,
                DepartmentName = x.Department.Names
            }).ToList();
            dg.ItemsSource = rec;

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            var rec = db.Students
                .Where(b => (txtsearch.Text==null || b.Names.Contains(txtsearch.Text)) &&
                            (txtdep.Text==null || b.Department.Names.Contains(txtdep.Text))).Select(x => new
                            {
                                x.ID,
                                Name = x.Names,
                                Address = x.Addres,
                                Age = x.Age,
                                DepartmentName = x.Department.Names
                            }).ToList();
            dg.ItemsSource = rec;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Student rec = new Student();
            int num = int.Parse(txtId.Text);
            rec = db.Students.FirstOrDefault(x => x.ID == num);
            if (rec != null)
            {
                db.Students.Remove(rec);
                db.SaveChanges();
                MessageBox.Show("the student was deleted");
                var rec2 = db.Students.Select(x => new
                {
                    x.ID,
                    Name = x.Names,
                    Address = x.Addres,
                    Age = x.Age,
                    DepartmentName = x.Department.Names
                }).ToList();
                dg.ItemsSource = rec2;
            }
            else
            {
                MessageBox.Show("you entered invalid password");
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Student rec = new Student();
            int num = int.Parse(txtId.Text);

            rec = db.Students.FirstOrDefault(x => x.ID == num);

            if (rec != null) 
            {
                var department = db.Departments.FirstOrDefault(d => d.Names == txtdep.Text);
                if (department != null)
                {
                    rec.DepId = department.Department_Id;
                }
                db.Students.AddOrUpdate(rec);
                db.SaveChanges();
                MessageBox.Show("data edited");
                var rec2 = db.Students.Select(x => new
                {
                    x.ID,
                    Name = x.Names,
                    Address = x.Addres,
                    Age = x.Age,
                    x.Department.Names
                }).ToList();
                dg.ItemsSource = rec2;
            }
            else
            {
                MessageBox.Show("you entered invalid password");
            }
        }
    }
}
