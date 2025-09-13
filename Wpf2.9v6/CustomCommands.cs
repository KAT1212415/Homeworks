using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf2._9v6
{
    internal class CustomCommands
    {
        public static RoutedUICommand ChangeColor { get; set; }
        static CustomCommands()
        {

            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            inputGestureCollection.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+W"));
            ChangeColor = new RoutedUICommand("ChangeColor", "ChangeColor", typeof(CustomCommands), inputGestureCollection);



        }
    }
}
