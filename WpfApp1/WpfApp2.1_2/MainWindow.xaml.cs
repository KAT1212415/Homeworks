using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2._1_2
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
        int result = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result++;
            Text1.Text = result.ToString();
            if (result % 3 == 0)
            {
                Ellipse1.Fill = Brushes.Gray;
                Ellipse2.Fill = Brushes.Gray;
                Ellipse3.Fill = Brushes.Green;
            }
            else
            {
                if ((result - 2) % 3 == 0)
                {
                    Ellipse1.Fill = Brushes.Gray;
                    Ellipse2.Fill = Brushes.Yellow;
                    Ellipse3.Fill = Brushes.Gray;
                }
                else
                {
                    Ellipse1.Fill = Brushes.Red;
                    Ellipse2.Fill = Brushes.Gray;
                    Ellipse3.Fill = Brushes.Gray;
                }
            }
        }
    }
}