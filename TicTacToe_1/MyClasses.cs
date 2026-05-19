using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace TicTacToe_1
{
    class Button : System.Windows.Controls.Button
    {
        public Button()
        {
            FontSize = 120;
            FontFamily = new System.Windows.Media.FontFamily("Calibri");
            Background = new SolidColorBrush(Colors.White);
            BorderBrush = new SolidColorBrush(Colors.Black);
        }

    }

}
