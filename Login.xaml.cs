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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        assiegnmentEntities db = new assiegnmentEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void loginn_Click(object sender, RoutedEventArgs e)
        {
            var rec = db.Students.FirstOrDefault(x=> x.Email == txtemail.Text && x.Passwords==txtpass.Password);
            if (rec != null)
            {
                NavigationService.Navigate(new Applications(rec.Email));
            }
            else
            {
                MessageBox.Show("you entered invalied data");
            }
        }

        private void sign_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sign_up());
        }
    }
}
