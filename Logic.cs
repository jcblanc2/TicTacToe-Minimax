using System;
using System.Linq;
using System.Windows.Forms;

namespace devoir3
{
    static class Logic
    {
        static int count = 0;
        static bool finish = false;
        static String[,] board = new String[3,3];
        public static void checkAndDisplay(Button btn)
        {
            ++count;
            if(btn.Text == String.Empty)
            {
                if (!finish)
                {
                    if(count % 2 == 0)
                    {
                        btn.Text = "X";
                        btn.ForeColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        btn.Text = "O";
                        btn.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                }
            }
        }

        public static void verify(Button btn)
        {
            if (!finish)
            {
                MiniMax.Move bestMove = MiniMax.findBestMove(board);

                int x = (int)Char.GetNumericValue(btn.Name.ElementAt(0));
                int y = (int)Char.GetNumericValue(btn.Name.ElementAt(1));

                board[x, y] = btn.Text.ToString();

                if (board[0, 0] != null && board[0, 0].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 2]))
                {
                    diaplayMessage(board[0, 0]);
                }


                if (board[0, 2] != null && board[0, 2].Equals(board[1, 1]) && board[1, 1].Equals(board[2, 0]))
                {
                    diaplayMessage(board[0, 2]);
                }


                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] != null && board[i, 0].Equals(board[i, 1]) && board[i, 1].Equals(board[i, 2]))
                    {
                        diaplayMessage(board[i, 0]);
                    }

                    if (board[0, i]  != null && board[0, i].Equals(board[1, i]) && board[1, i].Equals(board[2, i]))
                    {
                        diaplayMessage(board[0, i]);
                    }
                }


                if (count == 9 && finish != true)
                {
                    MessageBox.Show("Draw", "Tic Tac Toe");
                    finish = true;
                }
            }
        }


        private static void diaplayMessage(String winer)
        {
            if (!finish)
            {
                MessageBox.Show(winer + "   Won", "Tic Tac Toe");
                finish = true;
                return;
            }
            
        }

        public static void clear()
        {
            finish = false;
            count = 0;
            board = new String[3, 3];
        }
    }
}
