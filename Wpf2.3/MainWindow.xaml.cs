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

namespace Wpf2._3
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

        /*private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckBox1.IsChecked ?? false)
            {
                MessageBox.Show("Ошибка: Необходимо согласие на обработку данных");
                return;
            }
            //return;
            string CourseselectItem = string.Join(",", Course.SelectedItems.Cast<ListBoxItem>().Select(i => i.Content));

            string massage = $"Даннные отправлены\n\n" +
                        $"Студент: {NameStudent.Text}\n\n" +
                        $"Факультет:{Discipline.Text}\n\n " +
                        $"Курсы: {CourseselectItem}\n\n";
            //$"Курсы: {Course.Text} ";
            

            
            MessageBox.Show(massage);
        }
        
        
    }
         
      
}