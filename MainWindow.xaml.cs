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

namespace треугольник
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(sideA.Text);
                b = Convert.ToInt32(sideB.Text);
                c = Convert.ToInt32(sideC.Text);

                string result;

                if (a <= 0 ||  b <= 0 || c <= 0)
                {
                    MessageBox.Show("Стороны должны быть положительными числами.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (a + b <= c || b + c <= a || a + c <= b)
                {
                    MessageBox.Show("Условия треугольника не выполнены!" + "\r\n" + "Одна сторона превышает сумму двух других!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }


                if (a == b && b == c)
                {
                    result = "Равносторонний треугольник";
                }
                else if( a == b || b == c || a == c) 
                {
                    result = "Равнобедренный треугольник";
                }
                else
                {
                    result = "Разносторонний треугольник";
                }
                resultext.Text = result;
            }
            catch 
            {
                MessageBox.Show("Пожалуйста, заполните все поля" + "\r\n" + "Введите корректные целые числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sideA.Text = "";
            sideB.Text = "";
            sideC.Text = "";
            resultext.Text = "";
        }
    }
}
