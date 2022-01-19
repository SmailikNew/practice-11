using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace practice_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Дана строка aba aca aea abba adca abea. Напишите регулярное выражение, которое найдет строки abba adca abea. Дана строка ave a#b a2b a$b a4b a5b a-b acb. Напишите регулярное выражание, которое найдет строки следующего вида: по краям стоят буквы а и b, а между ними - не буква и не цифра.");
        }

        private void calculateforone(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a\w{2}a");
            MatchCollection matches = regex.Matches(inputstring1.Text);
            object[] array = new object[matches.Count];
            matches.CopyTo(array, 0);
            rez1.Text = string.Join(", ", array);
        }

        private void calculatefortwo(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a\Wb");
            MatchCollection matches = regex.Matches(inputstring2.Text);
            object[] array = new object[matches.Count];
            matches.CopyTo(array, 0);
            rez2.Text = string.Join(", ", array);
        }
    }
}
