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

namespace PR04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int N = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int getnumb(int numb)
        {
            int count = 0;
            while (numb != 0)
            {
                count++;
                numb /= 10;
            }
            return count;
        }


        private void ta_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            if (ta.Text == "" ) 
            {
                MessageBox.Show("ВВЕДИТЕ ЧИСЛО >:((");
                this.IsEnabled = false;
            }
            else
            {
                tb.Text = null;
                double q = 0;
                N = Convert.ToInt32(ta.Text);
                for (int i = 1; i < N; i++)
                {
                    if (getnumb(i) == 1)
                    {
                        q = Math.Pow(i, 1);
                        if (q == i)
                        {
                            tb.Text += i.ToString() + Environment.NewLine;
                        }
                    }
                    else if (getnumb(i) == 2)
                    {
                        int x = i % 10;
                        int y = i / 10;
                        q = Math.Pow(x, 2) + Math.Pow(y, 2);
                        if (q == i)
                        {
                            tb.Text += i.ToString() + Environment.NewLine;
                        }
                    }
                    else if (getnumb(i) == 3)
                    {
                        int x = i % 10;
                        int y = (i % 100) / 10;
                        int z = i / 100;
                        q = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                        if (q == i)
                        {
                            tb.Text += i.ToString() + Environment.NewLine;
                        }
                    }

                }

            }
        }
    }
}
