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
using static System.Net.Mime.MediaTypeNames;

namespace Wpf2._8v
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string MyImage { get; set; }
        public Product1 Product2 { get; set; }= null!;


        public MainWindow()
        {
            InitializeComponent();

            MyImage = "Image\\banana1.png";

            Product2 = new Product1 
            {
                Name = "еда",
                Price = "еда",
                ImageImage = "Image\\banana1.png", 
                category = "еда",
            };

            DataContext = this;

        }
       

        public class Product1
        {
            public string Name { get; set; } = "банан";
            public string Price { get; set; } = "100";
            public string ImageImage { get; set; } = "Images/banana1.png";
            public string category { get; set; } = "еда";
        }

    }

 
}