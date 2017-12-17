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
            if (valGetter.Text == "" || valGetter.Text == "1,2,3,4,...")
            {
                firstBtn.Content = "Generate";
            }
            else
            {
                firstBtn.Content = "Calculate";
            }
        }

        private void firstBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (valGetter.Text == "" || valGetter.Text == "1,2,3,4,...")
            {
                firstBtn.Content = "Generate";
            }
            else
            {
                firstBtn.Content = "Calculate";
            }
        }
        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            #region
            Random random = new Random();

            int rand = random.Next(0, 80);

            int[] myArray = Enumerable.Range(0, 50).ToArray();

            int[] myRandomArray = new int[50];

            for (int i = 0; i < myRandomArray.Length; i++)
            {
                myRandomArray[i] = random.Next(0, 80);
            }
            #endregion
            if (valGetter.Text == "1,2,3,4,..." || valGetter.Text == "" || valGetter.Text == " " || valGetter.Text == null)
            {
                if (binary.IsChecked == true)
                {
                    Binary(max: myArray.Length, inputArray: myArray, key: rand, min: 1);
                }

                else if (linear.IsChecked == true)
                {
                    Linear(max: myArray.Length, inputArray: myArray, key: rand, min: 1);
                }

                else if (qsort.IsChecked == true)
                {
                    QuickSort(max: myRandomArray.Length, inputArray: myRandomArray, min: 1);
                }

                else if (bsort.IsChecked == true)
                {
                    BubbleSort(max: myRandomArray.Length, inputArray: myRandomArray, min: 1);
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
            else
            {
                if (binary.IsChecked == true )
                {
                    if (valGetter.Text.Length > 2)
                    {
                        try
                        {
                            //int[] newIntArray = new int[50];
                            string[] newArray = valGetter.Text.Split(',').ToArray();
                            int[] newIntArray = Array.ConvertAll(newArray, int.Parse);
                            foreach (var item in newIntArray)
                            {
                                Binary(max: myArray.Length, inputArray: myArray, key: item, min: 1);
                            }
                        }
                        catch (FormatException)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"Values did not accepted.";
                        }
                        catch (Exception error)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"{error}";
                        }
                    }
                    else
                    {
                        Binary(max: myArray.Length, inputArray: myArray, key: int.Parse(valGetter.Text), min: 1);
                    }
                }

                else if (linear.IsChecked == true)
                {
                    if (valGetter.Text.Length > 2)
                    {
                        try
                        {
                            //int[] newIntArray = new int[50];
                            string[] newArray = valGetter.Text.Split(',').ToArray();
                            int[] newIntArray = Array.ConvertAll(newArray, int.Parse);
                            foreach (var item in newIntArray)
                            {
                                Linear(max: myArray.Length, inputArray: myArray, key: item, min: 1);
                            }
                        }
                        catch (FormatException)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"Values did not accepted.";
                        }
                        catch (Exception error)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"{error}";
                        }
                    }
                    else
                    {
                        Linear(max: myArray.Length, inputArray: myArray, key: int.Parse(valGetter.Text), min: 1);
                    }
                }

                else if (qsort.IsChecked == true && (valGetter.Text.IndexOf(',') != null || valGetter.Text.Length > 2))
                {
                    if (valGetter.Text.Length > 2)
                    {
                        try
                        {
                            //int[] newIntArray = new int[50];
                            string[] newArray = valGetter.Text.Split(',').ToArray();
                            int[] newIntArray = Array.ConvertAll(newArray, int.Parse);
                            QuickSort(max: newArray.Length, inputArray: newIntArray, min: 1);
                        }
                        catch (FormatException)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"Values did not accepted.";
                        }
                        catch (Exception error)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"{error}";
                        }
                    }
                    else
                    {
                        QuickSort(max: myRandomArray.Length, inputArray: myRandomArray, min: 1);
                    }
                }

                else if (bsort.IsChecked == true && (valGetter.Text.IndexOf(',') != null || valGetter.Text.Length > 2))
                {
                    if (valGetter.Text.Length > 2)
                    {
                        try
                        {
                            //int[] newIntArray = new int[50];
                            string[] newArray = valGetter.Text.Split(',').ToArray();
                            int[] newIntArray = Array.ConvertAll(newArray, int.Parse);
                            BubbleSort(max: newArray.Length, inputArray: newIntArray, min: 1);
                        }
                        catch(FormatException)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"Values did not accepted.";
                        }
                        catch (Exception error)
                        {
                            Color Red = new Color();
                            Red = Color.FromRgb(184, 35, 35);
                            lblText.Foreground = new SolidColorBrush(Red);
                            lblText.Text = $"{error}";
                        }
                    }
                    else
                    {
                        BubbleSort(max: myRandomArray.Length, inputArray: myRandomArray, min: 1);
                    }
                }

                else if (hanoi.IsChecked == true)
                {

                }

                else
                {
                    if (binary.IsChecked == false || linear.IsChecked == false || qsort.IsChecked == false || bsort.IsChecked == false || hanoi.IsChecked == false)
                    {
                        Color Red = new Color();
                        Red = Color.FromRgb(184, 35, 35);
                        lblText.Foreground = new SolidColorBrush(Red);
                        lblText.Text = "Please choose one of these boxes.";
                    }
                    else
                    {
                        Color Red = new Color();
                        Red = Color.FromRgb(184, 35, 35);
                        lblText.Foreground = new SolidColorBrush(Red);
                        lblText.Text = "Values did not accepted.";
                    }
                }
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
                        liView.Items.Add($"The generated value was {key} & founded in {Time} millisecond by Binary search.");
                        //Connect.ConnectionOpener(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\farva\Source\Repos\Algorithms\algorithm-speed\Algorithms\Assets\Algorithms.accdb;Persist Security Info=True", "INSERT INTO 'BinaryLog' ('Time', 'Number') VALUES ('" + int.Parse(Time.ToString()) + "','" + int.Parse(key.ToString()) + "')");
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
                        liView.Items.Add($"The generated value was {key} & founded in {Time} millisecond by Linear search.");
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
        public object QuickSort(int[] inputArray, int max, int min)
        {
            return max;
        }
        public object BubbleSort(int[] inputArray, int max, int min)
        {
            try
            {
                var sTime = DateTime.Now.Millisecond;
                int t;
                for (int p = 0; p <= inputArray.Length - 2; p++)
                {
                    System.Threading.Thread.Sleep(1);

                    for (int i = 0; i <= inputArray.Length - 2; i++)
                    {
                        if (inputArray[i] > inputArray[i + 1])
                        {
                            t = inputArray[i + 1];
                            inputArray[i + 1] = inputArray[i];
                            inputArray[i] = t;
                        }
                    }
                }
                Color Green = new Color();
                Green = Color.FromRgb(32, 238, 0);
                lblText.Foreground = new SolidColorBrush(Green);
                lblText.Text = "Yeah! We`ve sorted the array.";
                var fTime = DateTime.Now.Millisecond;
                int Time = fTime - sTime;
                liView.Items.Add($"The array were sorted in {Time} millisecond with these values by Bubble sort:");
                foreach (var item in inputArray)
                {
                    liView.Items.Add($"{item}");
                }
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
        public object Hanoi(int[] inputArray, int max, int min)
        {
            try
            {
                var sTime = DateTime.Now.Millisecond;
                int t;
                for (int p = 0; p <= inputArray.Length - 2; p++)
                {
                    System.Threading.Thread.Sleep(1);

                    for (int i = 0; i <= inputArray.Length - 2; i++)
                    {
                        if (inputArray[i] > inputArray[i + 1])
                        {
                            t = inputArray[i + 1];
                            inputArray[i + 1] = inputArray[i];
                            inputArray[i] = t;
                        }
                    }
                }
                Color Green = new Color();
                Green = Color.FromRgb(32, 238, 0);
                lblText.Foreground = new SolidColorBrush(Green);
                lblText.Text = "Yeah! We`ve sorted the array.";
                var fTime = DateTime.Now.Millisecond;
                int Time = fTime - sTime;
                liView.Items.Add($"The array were sorted in {Time} millisecond with these values by Bubble sort:");
                foreach (var item in inputArray)
                {
                    liView.Items.Add($"{item}");
                }
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

        private void Charts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Charts = new Charts(); //create your new form.
            Charts.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void valGetter_MouseEnter(object sender, MouseEventArgs e)
        {
            if (valGetter.Text == "1,2,3,4,..." || valGetter.Text == "")
            {
                valGetter.Text = "";
                firstBtn.Content = "Generate";
            }
            else
            {
                firstBtn.Content = "Calculate";
            }
        }

        private void valGetter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (valGetter.Text == "1,2,3,4,..." || valGetter.Text == "")
            {
                valGetter.Text = "";
                firstBtn.Content = "Generate";
            }
            else
            {
                firstBtn.Content = "Calculate";
            }
        }

        private void valGetter_MouseLeave(object sender, MouseEventArgs e)
        {
            if (valGetter.Text == "" || valGetter.Text == "1,2,3,4,...")
            {
                valGetter.Text = "1,2,3,4,...";
                firstBtn.Content = "Generate";
            }
            else
            {
                firstBtn.Content = "Calculate";
            }
        }

    }
}
