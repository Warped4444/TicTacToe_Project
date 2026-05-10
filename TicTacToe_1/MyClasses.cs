using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_1
{
    class Car
    {
        String color = "red";
        int currentSpeed = 0;
        Button accelerationButton = new Button();

        public void Accelerate()
        {
            currentSpeed = 100;
        }
        public void IncreaseTextSize()
        {
            string result = accelerationButton.MakeTextBigger(250);

            if (result == "fail")
                accelerationButton.MakeTextBigger(120);
        }
    }

    class Button
    {
        int fontSize = 60;

        public string MakeTextBigger(int size)
        {

            if (size <= 200)
            {
                fontSize = size;
                return "Success";
            }
            else
                return "fail";
            
        }
    }
}
