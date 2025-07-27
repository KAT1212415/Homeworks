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

namespace Wpf2._4
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



       /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ref1.Background = Brushes.Green;
            Ref1.Content = "цвет изменился";
        }*/
    }
    public partial class Button1 : Button
    {
        public static readonly DependencyProperty IsToggledProperty = DependencyProperty.Register
            (nameof(IsToggled), 
            typeof(bool),
            typeof(Button1),
            new PropertyMetadata(false, IsToggledChanged));
        public bool IsToggled
        {  get=>(bool)GetValue(IsToggledProperty);
           set=>SetValue(IsToggledProperty, value); }

        private static void IsToggledChanged(DependencyObject d,DependencyPropertyChangedEventArgs e)

        { var button = (Button1)d;
            bool newvalue = (bool)e.NewValue;
            if (newvalue == true) { button.Content = "on"; button.Background = Brushes.Green; }
            else { button.Content = "off"; button.Background = Brushes.Red; }
        }

        public  Button1 ()
        { IsToggled = false;
            Click +=(s,e)=> IsToggled=!IsToggled;


        }


    }
}