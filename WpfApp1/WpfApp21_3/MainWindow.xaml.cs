using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp21_3
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

        private void TextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int maingridWidth = Convert.ToInt32(Maingrid.Width);
            int maingridHeight= Convert.ToInt32(Maingrid.Height);
        
            int a=random.Next(0, maingridWidth);
            int b=random.Next(0, maingridHeight);
            TextBox1.Margin = new Thickness(a,b,0,0);
        }

        private void TextBox1_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}