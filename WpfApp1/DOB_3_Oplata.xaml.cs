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
    /// Логика взаимодействия для DOB_3_Oplata.xaml
    /// </summary>
    public partial class DOB_3_Oplata : Window
    {
        public DOB_3_Oplata()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Главное_окно frm = new Главное_окно();
            frm.Show();
            this.Hide();
        }
    }
}
