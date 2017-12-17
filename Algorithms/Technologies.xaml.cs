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

namespace Algorithms
{
    /// <summary>
    /// Interaction logic for Technologies.xaml
    /// </summary>
    public partial class Technologies : Window
    {
        public Technologies()
        {
            InitializeComponent();
        }

        private void Home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var MainWindow = new MainWindow(); //create your new form.
            MainWindow.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void Charts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Charts = new Charts(); //create your new form.
            Charts.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void Resources_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Resources = new Resources(); //create your new form.
            Resources.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void Developer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Developer = new Developer(); //create your new form.
            Developer.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }
    }
}
