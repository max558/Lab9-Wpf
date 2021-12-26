using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GraphicReader
{
    class MyCommandCanvas
    {
        public static RoutedUICommand Exit { get; set; }
        
        public static RoutedUICommand Pencil { get; set; }
        public static RoutedUICommand Eraser { get; set; }
        public static RoutedUICommand AllClear { get; set; }
        
        static MyCommandCanvas()
        {
            InputGestureCollection inputsExit = new InputGestureCollection();
            inputsExit.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
            Exit = new RoutedUICommand("_Выход", "Exit", typeof(MyCommandCanvas), inputsExit);
            
            InputGestureCollection inputsPencil = new InputGestureCollection();
            inputsPencil.Add(new KeyGesture(Key.K, ModifierKeys.Control, "Ctrl+K"));
            Pencil = new RoutedUICommand("Карандаш", "Pencil", typeof(MyCommandCanvas), inputsPencil);

            InputGestureCollection inputsEraser = new InputGestureCollection();
            inputsEraser.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E"));
            Eraser = new RoutedUICommand("Ластик", "Eraser", typeof(MyCommandCanvas), inputsEraser);

            InputGestureCollection inputsClear = new InputGestureCollection();
            inputsClear.Add(new KeyGesture(Key.D, ModifierKeys.Control, "Ctrl+D"));
            AllClear = new RoutedUICommand("Очистить все", "AllClear", typeof(MyCommandCanvas), inputsClear);            
        }


    }
}
