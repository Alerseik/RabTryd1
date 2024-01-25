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
    /// Логика взаимодействия для ST_3_Oplata.xaml
    /// </summary>
    public partial class ST_3_Oplata : Page
    {
        public ST_3_Oplata()
        {
            InitializeComponent();
            dt = new DataBase_3_Oplata();
            MySqlCommand command = new MySqlCommand("SELECT id_students,new_pabota.faculty.name_faculty, new_pabota.group.name_group, fio, date_birthg, adress, telephone, Number FROM new_pabota.students "
                + "JOIN new_pabota.faculty on students.education = new_pabota.faculty.name_faculty "
                + "JOIN new_pabota.group on students.id_group = new_pabota.group.id_group;", dt.getConnection());
            DataTable de = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(de);
            DG1.ItemsSource = de.AsDataView();
            dt.closeConnecrion();
        }
        DataBase_3_Oplata dt;
    }
}
