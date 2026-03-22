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
using ZelenikinPractica2;

namespace WPFCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbCommand.Clear();
            foreach (UIElement element in MainLayout.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string TextButton = ((Button)e.OriginalSource).Content.ToString();

            if (TextButton == "C")
            {
                tbCommandHistory.Clear();
                tbCommand.Clear();
            }
            else if (TextButton == "=")
            {
                string expr = tbCommand.Text;
                char[] ops = { '+', '-', '*', '/', '^' };
                int pos = -1;
                char op = ' ';
                for (int i = 0; i < expr.Length; i++)
                {
                    if (Array.IndexOf(ops, expr[i]) >= 0)
                    {
                        pos = i;
                        op = expr[i];
                        break;
                    }
                }
                if (pos != -1)
                {
                    string num1Text = expr.Substring(0, pos);
                    string num2Text = expr.Substring(pos + 1);

                    double num1 = double.Parse(num1Text);
                    double num2 = double.Parse(num2Text);

                    dynamic res = Class1.Exicute(num1, op, num2);

                    tbCommandHistory.Text = $"{expr} =";
                    tbCommand.Text = res.ToString();
                }
            }
            else
            {
                tbCommand.Text += TextButton;
            }
        }
    }
}
