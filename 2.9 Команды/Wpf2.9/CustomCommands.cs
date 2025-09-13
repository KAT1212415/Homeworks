using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf2._9
{
    class CustomCommands
    {
        public static RoutedUICommand ChangeColor { get; set; }
        static CustomCommands()
        {
            ChangeColor= new RoutedUICommand("ChangeColor", "ChangeColor",typeof(CustomCommands));
        }


    }
}
