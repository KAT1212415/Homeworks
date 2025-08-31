using System.Collections.ObjectModel;
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

namespace Wpf2._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        //public Product2 product1 { get; set; } = null!;
        public ObservableCollection<Product2> product1= new ObservableCollection<Product2>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            product1.Add (new Product2()
            {
                Name = "банан",
                Price = "цена",
                Image = "Image\\banana1.png",
                category = Type.food,
            });
            product1.Add(new Product2()
            {
                Name = "яблоко",
                Price = "цена",
                Image = "Image\\banana1.png",
                category = Type.technique,
            });


           
        }
    }

    public enum Type
    {
        food,
        technique
    }

    public class Product2
    {
        public string? Name { get; set; } 
        public string? Price { get; set; } 
        public string? Image { get; set; }
        public Type category { get; set; } 
    }
}
