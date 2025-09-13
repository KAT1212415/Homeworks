using System;
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

namespace Wpf2._9v4
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
        SolidColorBrush myBrush = Brushes.Red;

        private Stack<SolidColorBrush> _colorHistory = new Stack<SolidColorBrush>();

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            var random = new Random();
            myBrush = new SolidColorBrush(Color.FromRgb(
          (byte)random.Next(256),
          (byte)random.Next(256),
          (byte)random.Next(256)));
            if (_colorHistory.Count == 0 || _colorHistory.Peek().Color != myBrush.Color)
            {
                _colorHistory.Push(myBrush);
            }
            Meinmenu.Background = myBrush;
            //MessageBox.Show($"Цвет изменен на: {myBrush}");
        }

       private void UndoExecuted(object sender, RoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop(); // Удаляем текущий цвет
                myBrush = _colorHistory.Peek(); // Берём предыдущий
            }

            Meinmenu.Background = myBrush;
            //MessageBox.Show($"Цвет изменен на: {myBrush}");


        }
    }
}