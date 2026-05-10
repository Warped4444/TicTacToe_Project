using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TicTacToe_1
{
    class Car
    {
        String color = "red";
        protected int currentSpeed = 0;
        Button accelerationButton = new Button();

        public virtual void Accelerate()
        {
            currentSpeed = 100;
        }
        public void IncreaseTextSize()
        {
            double size = accelerationButton.FontSize; 
            accelerationButton.FontSize = 1000;

            string result = accelerationButton.MakeTextBigger(250);

            if (result == "fail")
                accelerationButton.MakeTextBigger(120);
        }
    }

    class FastCar : Car
    {
        public override void Accelerate()
        {
            currentSpeed = 200;
        }
    }

    class Button : System.Windows.Controls.Button
    {
        public Button()
        {
            FontSize = 120;
            FontFamily = new System.Windows.Media.FontFamily("Calibri");
            Background = new SolidColorBrush(Colors.White);
            BorderBrush = new SolidColorBrush(Colors.Black);
        }

        public string MakeTextBigger(int size)
        {

            if (size <= 200)
            {
                FontSize = size;
                return "Success";
            }
            else
                return "fail";
            
        }

       

    }
}
