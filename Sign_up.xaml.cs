using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assiment2
{
    /// <summary>
    /// Interaction logic for Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Page
    {
        assiegnmentEntities db = new assiegnmentEntities();
        public Sign_up()
        {
            InitializeComponent();
        }

        private void sign_Click(object sender, RoutedEventArgs e)
        {
            Student rec = new Student();
            rec.Names = txtname.Text;
            rec.Email =txtemail.Text;
            if(txtpass.Text == txtconfirm.Text )
            {
                rec.Passwords = txtpass.Text;
                db.Students.Add(rec);
                db.SaveChanges();
                NavigationService.Navigate(new Login());
            }
            else
            {
                MessageBox.Show("you entered invalid password");
            }
        }
    }
}
