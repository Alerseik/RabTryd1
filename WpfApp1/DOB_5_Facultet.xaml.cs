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
    /// Логика взаимодействия для DOB_5_Facultet.xaml
    /// </summary>
    public partial class DOB_5_Facultet : Window
    {
        public DOB_5_Facultet()
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
