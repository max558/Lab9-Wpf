using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TextReader
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand Bold { get; set; }
        public static RoutedUICommand Italic { get; set; }
        public static RoutedUICommand UnderLine { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputsExit = new InputGestureCollection();
            inputsExit.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
            Exit = new RoutedUICommand("_Выход", "Exit", typeof(MyCommands),inputsExit);

            InputGestureCollection inputsShrt = new InputGestureCollection();
            inputsShrt.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
            Bold = new RoutedUICommand("Жирный", "Bold", typeof(MyCommands), inputsShrt);
            inputsShrt.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Ctrl+I"));
            Italic = new RoutedUICommand("Курсив", "Italic", typeof(MyCommands), inputsShrt);
            inputsShrt.Add(new KeyGesture(Key.U, ModifierKeys.Control, "Ctrl+U"));
            UnderLine = new RoutedUICommand("Подчеркнутый", "UnderLine", typeof(MyCommands), inputsShrt);
        }
            
    }
}
