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
using System.IO;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace SlavaWorkz
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

        private void BtnValid_Click(object sender, RoutedEventArgs e)
        {
            // Определяем регулярные выражения для проверки ввода
            Lb.Content = Class.Verification(TbFirstName.Text, TbSecondName.Text, TbTelNumber.Text);
        }
    }

}