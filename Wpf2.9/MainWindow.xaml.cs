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

namespace Wpf2._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private Stack<Brush> _colorHistory = new Stack<Brush>();

        private Brush ?_currentColor;
        public Brush CurrentColor
        {
            get => _currentColor;
            set
            {
              

                // Добавляем новый цвет в стек, если предыдущий цвет не такой же
                // (либо стек пустой) 
                if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
                {
                    _colorHistory.Push(value);
                }
                // Dock - это имя (x:Name) контейнера компоновки, для которого меняем цвет
                
            }
        }
       
     
       
      
        private void ChangeColorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var random = new Random();
            // CurrentColor - это свойство для хранения текущего цвета
            // ниже описано, как оно устроено
            CurrentColor = new SolidColorBrush(Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)));
            MessageBox.Show($"Цвет изменен на: {CurrentColor}");
            CancelButton.Background = CurrentColor;
            Meinmenu.Background = CurrentColor;
           
        }
        private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop(); // Удаляем текущий цвет
                CurrentColor = _colorHistory.Peek(); // Берём предыдущий
            }
            Meinmenu.Background = CurrentColor;
            CancelButton.Background = CurrentColor;

        }




    }
}