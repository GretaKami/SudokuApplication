using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public class SudokuCells : Button
    {
        public Font Font { get; set; }
        public Size Size { get; set; }
        //public Color ForeColor { get; set; }
        public Point Location { get; set; }
        public Color BackColor { get; internal set; }
        public FlatStyle FlatStyle { get; set; }
        public object FlatAppearance { get; set; }
        public System.Drawing.Color BorderColor { get; set; }
        public static object Controls { get; set; }
        public Action<object, KeyPressEventArgs> KeyPress { get; set; }



        public int X { get; set; }
        public int Y { get; set; }
        public string ButtonText { get; internal set; }
        public int Value { get; set; }
        public bool IsLocked { get; set; }

        internal void Clear()
        {
            this.Text = string.Empty;
        }
    }
}
