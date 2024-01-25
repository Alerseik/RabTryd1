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
    /// Логика взаимодействия для Главное_окно.xaml
    /// </summary>
    public partial class Главное_окно : Window
    {
        public Главное_окно()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            Frame_1.Content = new ST_1_Stydent();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            Frame_1.Content = new ST2_Sanatorie();
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            Frame_1.Content = new ST_3_Oplata();
        }
        private void Meny_KN1_Click(object sender, RoutedEventArgs e)
        {
            DOB_1_Stydent frm = new DOB_1_Stydent();
            frm.Show();
            this.Hide();
        }
        private void Meny_KN2_Click(object sender, RoutedEventArgs e)
        {
            DOB_2_Sanatorie frm = new DOB_2_Sanatorie();
            frm.Show();
            this.Hide();
        }
        private void Meny_KN3_Click(object sender, RoutedEventArgs e)
        {
            DOB_3_Oplata frm = new DOB_3_Oplata();
            frm.Show();
            this.Hide();
        }
        private void Meny_KN4_Click(object sender, RoutedEventArgs e)
        {
            DOB_4_POplata frm = new DOB_4_POplata();
            frm.Show();
            this.Hide();
        }
        private void Meny_KN5_Click(object sender, RoutedEventArgs e)
        {
            DOB_5_Facultet frm = new DOB_5_Facultet();
            frm.Show();
            this.Hide();
        }
        private void Meny_KN6_Click(object sender, RoutedEventArgs e)
        {
            DOB_6_Grup frm = new DOB_6_Grup();
            frm.Show();
            this.Hide();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
