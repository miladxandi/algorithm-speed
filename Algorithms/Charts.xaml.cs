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
    /// Interaction logic for Charts.xaml
    /// </summary>
    public partial class Charts : Window
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Home_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var MainWindow = new MainWindow(); //create your new form.
            MainWindow.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void Resources_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Resources = new Resources(); //create your new form.
            Resources.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void Technologies_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var Technologies = new Technologies(); //create your new form.
            Technologies.Show(); //show the new form.
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
