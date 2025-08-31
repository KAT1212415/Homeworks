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

namespace Wpf2._8v3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> product1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            product1 = new ObservableCollection<Product>();

            // Добавляем товары
            product1.Add(new Product(
               name: "Банан",
               price: "50 руб",
               image: "Image\\1.png",
               category: Category.Food
           ));
            product1.Add(new Product(
             name: "Холодильник",
             price: "15000 руб",
             image: "Image\\2.png",
             category: Category.technique
            ));
            product1.Add(new Product(
            name: "Яблоки",
            price: "250 руб",
            image: "Image\\3.png",
            category: Category.Food
        ));



            DataContext = this;
        }

        public enum Category
        {
            Food,
            technique
        }

        public class Product

        {

            public Product(string name, string price, string image, Category category)
            {
                Name = name;
                Price = price;
                Image = image;
                Category = category;
            }

            public string Name { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }
            public Category Category { get; set; }
        }
    }
}
