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

namespace WpfApp1
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
            Random random = new Random();
            int a=random.Next(0, Convert.ToInt32(NameGrid.ActualWidth));
            double b= random.Next(0, Convert.ToInt32(NameGrid.ActualHeight));
            Button1.Margin=new Thickness(a,b,0,0);

        }
    }
}