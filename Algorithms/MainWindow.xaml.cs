using System;
using System.Data.OleDb;
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
using AccessConnector;
namespace Algorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void firstBtn_MouseLeave(object sender, MouseEventArgs e)
        {

        }



        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            /* List<int> ID = new List<int> { random.Next(0, int.Parse(txtBox.Text) * 100) };*/
            int[] myID = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            if (binary.IsChecked == true)
            {
                Binary(max: myID.Length, inputArray: myID, key: random.Next(1, 80), min: 1);
            }
            else if (linear.IsChecked == true)
            {
                Linear(max: myID.Length, inputArray: myID, key: random.Next(1, 80), min: 1);
            }
            else if (qsort.IsChecked == true)
            {
            }
            else if (bsort.IsChecked == true)
            {
            }
            else if (hanoi.IsChecked == true)
            {
            }
            else
            {
                Color Red = new Color();
                Red = Color.FromRgb(184, 35, 35);
                lblText.Foreground = new SolidColorBrush(Red);
                lblText.Text = "Please choose one of these boxes.";
            }
        }
        public object Binary(int[] inputArray, int key, int max, int min)
        {
            try
            {
                var sTime = DateTime.Now.Millisecond;

                while (min <= max)
                {
                    System.Threading.Thread.Sleep(1);

                    int mid = (min + max) / 2;
                    if (key == inputArray[mid])
                    {
                        Color Green = new Color();
                        Green = Color.FromRgb(32, 238, 0);
                        lblText.Foreground = new SolidColorBrush(Green);
                        lblText.Text = $"Yeah! We`ve found {key} .";
                        var fTime = DateTime.Now.Millisecond;
                        int Time = fTime - sTime;
                        liView.Items.Add($"The generated value was {key} & founded in {Time} millisecond with Binary search.");
                        //Connect.ConnectionOpener(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\farva\Source\Repos\Algorithms\Algorithms\Assets\Algorithms.accdb;Persist Security Info=True", "INSERT INTO BinaryLog ([Time], [Number]) VALUES('" + int.Parse(Time.ToString()) + "','" + int.Parse(key.ToString()) + "')");
                        return ++mid;
                    }
                    else if (key < inputArray[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }

                return "Nah! the value not found";
            }
            catch (IndexOutOfRangeException)
            {
                Color Red = new Color();
                Red = Color.FromRgb(184, 35, 35);
                lblText.Foreground = new SolidColorBrush(Red);
                lblText.Text = $"Nah! We cant find {key} .";
                return "Nah! the value not found";
            }
            catch (Exception error)
            {
                Color Red = new Color();
                Red = Color.FromRgb(184, 35, 35);
                lblText.Foreground = new SolidColorBrush(Red);
                lblText.Text = $"Nah! The {error.Message} value did not found";
                return $"Nah! The {error.Message} value did not found";
            }
        }
        public object Linear(int[] inputArray, int key, int max, int min)
        {
            try
            {
                var sTime = DateTime.Now.Millisecond;
                for (int k = min; k < max; k++)
                {
                    System.Threading.Thread.Sleep(1);

                    if (inputArray[k] == key)
                    {
                        Color Green = new Color();
                        Green = Color.FromRgb(32, 238, 0);
                        lblText.Foreground = new SolidColorBrush(Green);
                        lblText.Text = $"Yeah! We`ve found {key} .";
                        var fTime = DateTime.Now.Millisecond;
                        int Time = fTime - sTime;
                        liView.Items.Add($"The generated value was {key} & founded in {Time} millisecond with Linear search.");
                        //Connect.ConnectionOpener(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\farva\Source\Repos\Algorithms\Algorithms\Assets\Algorithms.accdb;Persist Security Info=True", "INSERT INTO BinaryLog ([Time], [Number]) VALUES('" + int.Parse(Time.ToString()) + "','" + int.Parse(key.ToString()) + "')");
                        return k;
                    }

                }
                return "Nah! the value not found";
            }
            catch (IndexOutOfRangeException)
            {
                Color Red = new Color();
                Red = Color.FromRgb(184, 35, 35);
                lblText.Foreground = new SolidColorBrush(Red);
                lblText.Text = $"Nah! We cant find {key} .";
                return "Nah! the value not found";
            }
            catch (Exception error)
            {
                Color Red = new Color();
                Red = Color.FromRgb(184, 35, 35);
                lblText.Foreground = new SolidColorBrush(Red);
                lblText.Text = $"Nah! The {error.Message} value did not found";
                return $"Nah! The {error.Message} value did not found";
            }
        }
    }
}
