using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string currentLetter = "X";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as TicTacToe_1.Button;
            if (button.Content != null && button.Content.ToString() != "")
            {
                MessageBox.Show("This cell is already occupied. Please choose another one.");
                return;
            }
            button.Content = currentLetter;
            
            button.IsEnabled = false;

            if (CheckForWin())
                {
                    StatusLable.Content =$"Player {currentLetter} wins!";

                MessageBox.Show($"Player {currentLetter} wins!", "Game Over");

                    ResetGame();

                    return;
                }

                if (CheckForDraw())
                {
                    StatusLable.Content = "It's a draw!";
                    MessageBox.Show("It's a draw!", "Game Over");
                    ResetGame();
                    return;
                }

                currentLetter = currentLetter == "X" ? "O" : "X";

                StatusLable.Content = $"player {currentLetter}'s turn";



        }
         private bool CheckForWin()
        {
            var cells = new string[9];
            for (int i = 0; i < 9; i++)
            {
                var button = GameGrid.Children[i] as TicTacToe_1.Button;

                cells[i] = button.Content?.ToString() ?? "";
            }

            int[,] winLines = new int[,]
            {
                {0, 1, 2}, // Top Row
                {3, 4, 5}, // Middle Row
                {6, 7, 8}, // Bottom Row
                {0, 3, 6}, // Left Column
                {1, 4, 7}, // Ceter Column
                {2, 5, 8}, // Right Column
                {0, 4, 8}, // Diagonal Top-Left to Bottom-Right
                {2, 4, 6} // Diagonal Top-Right to Bottom-Left
            };

            for (int i = 0; i < 8; i++)
            {
                string a = cells[winLines[i, 0]];
                string b = cells[winLines[i, 1]];
                string c = cells[winLines[i, 2]];

                if (a != "" && a == b && b == c)
                {
                    return true;
                }
                
            }
            return false;
        }

        private bool CheckForDraw()
        {
            foreach (TicTacToe_1.Button button in GameGrid.Children)
            {
                if (button.Content == null || button.Content.ToString() == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void ResetGame()
        {
            foreach (TicTacToe_1.Button button in GameGrid.Children)
            {
                button.Content = "";
                button.IsEnabled = true;
            }
            currentLetter = "X";
            StatusLable.Content = $"Player {currentLetter}'s turn";
        }
    }
}
