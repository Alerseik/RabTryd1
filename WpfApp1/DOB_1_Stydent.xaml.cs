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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для DOB_1_Stydent.xaml
    /// </summary>
    public partial class DOB_1_Stydent : Window
    {
        public DOB_1_Stydent()
        {
            InitializeComponent();
        }

        private void KN_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Главное_окно frm = new Главное_окно();
            frm.Show();
            this.Hide();
        }
    }
}
