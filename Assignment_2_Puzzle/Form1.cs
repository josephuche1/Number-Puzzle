// Uche Joseph Ugochukwu
namespace Assignment_2_Puzzle
{
    public partial class Form1 : Form
    {
        bool isWinning;
        int moves = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public bool winGame(TableLayoutPanel gameGrid)
        {
            // Get the positions of the buttons
            TableLayoutPanelCellPosition pos1 = gameGrid.GetPositionFromControl(btn_1);
            TableLayoutPanelCellPosition pos2 = gameGrid.GetPositionFromControl(btn_2);
            TableLayoutPanelCellPosition pos3 = gameGrid.GetPositionFromControl(btn_3);
            TableLayoutPanelCellPosition pos4 = gameGrid.GetPositionFromControl(btn_4);
            TableLayoutPanelCellPosition pos5 = gameGrid.GetPositionFromControl(btn_5);
            TableLayoutPanelCellPosition pos6 = gameGrid.GetPositionFromControl(btn_6);
            TableLayoutPanelCellPosition pos7 = gameGrid.GetPositionFromControl(btn_7);
            TableLayoutPanelCellPosition pos8 = gameGrid.GetPositionFromControl(btn_8);

            if (pos1.Row == 0 && pos1.Column == 0 &&
                pos2.Row == 0 && pos2.Column == 1 &&
                pos3.Row == 0 && pos3.Column == 2 &&
                pos4.Row == 1 && pos4.Column == 0 &&
                pos5.Row == 1 && pos5.Column == 1 &&
                pos6.Row == 1 && pos6.Column == 2 &&
                pos7.Row == 2 && pos7.Column == 0 &&
                pos8.Row == 2 && pos8.Column == 1)
            {
                gameGrid.Enabled = false;
                FireWorks1.Visible = true;
                Fireworks2.Visible = true;
                return true;
            }
            else if (pos1.Row == 0 && pos1.Column == 0 &&
                    pos2.Row == 0 && pos2.Column == 1 &&
                    pos3.Row == 0 && pos3.Column == 2 &&
                    pos4.Row == 1 && pos4.Column == 2 &&
                    pos5.Row == 2 && pos5.Column == 2 &&
                    pos6.Row == 2 && pos6.Column == 1 &&
                    pos7.Row == 2 && pos7.Column == 0 &&
                    pos8.Row == 1 && pos8.Column == 0)
            {
                gameGrid.Enabled = false;
                FireWorks1.Visible = true;
                Fireworks2.Visible = true;
                return true;
            }
            else { return false; }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_1);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_1, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_1, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_1, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_1, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_1, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_1, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_1, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_2);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_2, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_2, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_2, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_2, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_2, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_2, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_2, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_3);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_3, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_3, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_3, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_3, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_3, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_3, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_3, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_4);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_4, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_4, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_4, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_4, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_4, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_4, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_4, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_5);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_5, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_5, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_5, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_5, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_5, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_5, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_5, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_6);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_6, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_6, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_6, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_6, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_6, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_6, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_6, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_7);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_7, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_7, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_7, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_7, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_7, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_7, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_7, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Control control;
            TableLayoutPanelCellPosition newPosition;
            TableLayoutPanelCellPosition position = gameGrid.GetCellPosition(btn_8);
            if (position.Row == 0)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_8, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_8, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }

            }
            else if (position.Row == 1)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row + 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row + 1);
                    gameGrid.SetCellPosition(btn_8, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else
                {
                    control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }

                if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_8, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            else if (position.Row == 2)
            {
                control = gameGrid.GetControlFromPosition(position.Column, position.Row - 1);
                if (control == null)
                {
                    newPosition = new TableLayoutPanelCellPosition(position.Column, position.Row - 1);
                    gameGrid.SetCellPosition(btn_8, newPosition);
                    moves += 1;
                    movesCountlbl.Text = "Moves #" + moves.ToString();
                }
                else if (position.Column == 0 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
                else if (position.Column == 1 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column + 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column + 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                    else
                    {
                        control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                        if (control == null)
                        {
                            newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                            gameGrid.SetCellPosition(btn_8, newPosition);
                            moves += 1;
                            movesCountlbl.Text = "Moves #" + moves.ToString();
                        }
                    }
                }
                else if (position.Column == 2 && control != null)
                {
                    control = gameGrid.GetControlFromPosition(position.Column - 1, position.Row);
                    if (control == null)
                    {
                        newPosition = new TableLayoutPanelCellPosition(position.Column - 1, position.Row);
                        gameGrid.SetCellPosition(btn_8, newPosition);
                        moves += 1;
                        movesCountlbl.Text = "Moves #" + moves.ToString();
                    }
                }
            }
            isWinning = winGame(gameGrid);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Create a list of integers representing the positions of the buttons
            List<int> positions = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                positions.Add(i);
            }

            // Shuffle the list to generate random positions for the buttons
            Random random = new Random();
            int n = positions.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = positions[k];
                positions[k] = positions[n];
                positions[n] = value;
            }

            // Assign the buttons to the cells in the grid
            int index = 0;
            foreach (Button button in gameGrid.Controls)
            {
                if (index < 8)
                {
                    int position = positions[index];
                    int row = position / 3;
                    int col = position % 3;
                    gameGrid.SetCellPosition(button, new TableLayoutPanelCellPosition(row, col));
                    index++;
                }
                else
                {
                    // Hide the remaining button
                    button.Visible = false;
                }
            }
            gameGrid.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a list of integers representing the positions of the buttons
            List<int> positions = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                positions.Add(i);
            }

            // Shuffle the list to generate random positions for the buttons
            Random random = new Random();
            int n = positions.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = positions[k];
                positions[k] = positions[n];
                positions[n] = value;
            }

            // Assign the buttons to the cells in the grid
            int index = 0;
            foreach (Button button in gameGrid.Controls)
            {
                if (index < 8)
                {
                    int position = positions[index];
                    int row = position / 3;
                    int col = position % 3;
                    gameGrid.SetCellPosition(button, new TableLayoutPanelCellPosition(row, col));
                    index++;
                }
                else
                {
                    // Hide the remaining button
                    button.Visible = false;
                }
            }
            gameGrid.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PRogrammers Name: Uche Joseph Ugochukwu");
        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beginnerToolStripMenuItem.Checked = true;
            advancedToolStripMenuItem.Checked = false;
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            advancedToolStripMenuItem.Checked = true;
            beginnerToolStripMenuItem.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_1.ForeColor = Color.Red;
            btn_2.ForeColor = Color.Red;
            btn_3.ForeColor = Color.Red;
            btn_4.ForeColor = Color.Red;
            btn_5.ForeColor = Color.Red;
            btn_6.ForeColor = Color.Red;
            btn_7.ForeColor = Color.Red;
            btn_8.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_1.ForeColor = Color.Blue;
            btn_2.ForeColor = Color.Blue;
            btn_3.ForeColor = Color.Blue;
            btn_4.ForeColor = Color.Blue;
            btn_5.ForeColor = Color.Blue;
            btn_6.ForeColor = Color.Blue;
            btn_7.ForeColor = Color.Blue;
            btn_8.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_1.ForeColor = Color.Green;
            btn_2.ForeColor = Color.Green;
            btn_3.ForeColor = Color.Green;
            btn_4.ForeColor = Color.Green;
            btn_5.ForeColor = Color.Green;
            btn_6.ForeColor = Color.Green;
            btn_7.ForeColor = Color.Green;
            btn_8.ForeColor = Color.Green;
        }
    }
}