using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ST_1_Stydent.xaml
    /// </summary>
    public partial class ST_1_Stydent : Page
    {
        public ST_1_Stydent()
        {
            InitializeComponent();
            dt = new DataBase_1_Stydent();
            MySqlCommand command = new MySqlCommand("select * from new_pabota.students", dt.getConnection());
            DataTable de = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(de);
            DG1.ItemsSource = de.AsDataView();
            dt.closeConnecrion();
        }
        DataBase_1_Stydent dt;

        private void KN1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
