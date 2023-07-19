using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{

    public partial class ConnectFour : Form
    {
        enum GameStatusenum { NotStarted, Playing, Tie, Winner }
        GameStatusenum gamestatus = GameStatusenum.NotStarted;

        enum TurnEnum { Red, Yellow }
        TurnEnum currentturn = TurnEnum.Red;

        List<Label> lstlabels;
        List<List<Label>> lstwinningsets;
        List<Button> lstbuttons;

        List<Label> lstl1;
        List<Label> lstl2;
        List<Label> lstl3;
        List<Label> lstl4;
        List<Label> lstl5;
        List<Label> lstl6;
        List<Label> lstl7;

        bool playcomputer = false;
        public ConnectFour()
        {
            InitializeComponent();
            lstlabels = new() {
            lblGrid1, lblGrid2, lblGrid3, lblGrid4, lblGrid5, lblGrid6, lblGrid7, lblGrid8, lblGrid9,
            lblGrid10, lblGrid11, lblGrid12, lblGrid13, lblGrid14, lblGrid15, lblGrid16, lblGrid17, lblGrid18, lblGrid19,
            lblGrid20, lblGrid21, lblGrid22, lblGrid23, lblGrid24, lblGrid25, lblGrid26, lblGrid27, lblGrid28, lblGrid29,
            lblGrid30, lblGrid31, lblGrid32, lblGrid33, lblGrid34, lblGrid35, lblGrid36, lblGrid37, lblGrid38, lblGrid39,
            lblGrid40, lblGrid41, lblGrid42
            };

            lstl1 = new() { lblGrid36, lblGrid29, lblGrid22, lblGrid15, lblGrid8, lblGrid1 };
            lstl2 = new() { lblGrid37, lblGrid30, lblGrid23, lblGrid16, lblGrid9, lblGrid2 };
            lstl3 = new() { lblGrid38, lblGrid31, lblGrid24, lblGrid17, lblGrid10, lblGrid3 };
            lstl4 = new() { lblGrid39, lblGrid32, lblGrid25, lblGrid18, lblGrid11, lblGrid4 };
            lstl5 = new() { lblGrid40, lblGrid33, lblGrid26, lblGrid19, lblGrid12, lblGrid5 };
            lstl6 = new() { lblGrid41, lblGrid34, lblGrid27, lblGrid20, lblGrid13, lblGrid6 };
            lstl7 = new() { lblGrid42, lblGrid35, lblGrid28, lblGrid21, lblGrid14, lblGrid7 };

            lstwinningsets = new()
            {
                 new() {lblGrid1, lblGrid2, lblGrid3, lblGrid4},
                 new() {lblGrid2, lblGrid3, lblGrid4, lblGrid5},
                 new() {lblGrid3, lblGrid4, lblGrid5, lblGrid6},
                 new() {lblGrid4, lblGrid5, lblGrid6, lblGrid7},
                 new() {lblGrid8, lblGrid9, lblGrid10, lblGrid11},
                 new() {lblGrid9, lblGrid10, lblGrid11, lblGrid12},
                 new() {lblGrid10, lblGrid11, lblGrid12, lblGrid13},
                 new() {lblGrid11, lblGrid12, lblGrid13, lblGrid14},
                 new() {lblGrid15, lblGrid16, lblGrid17, lblGrid18},
                 new() {lblGrid16, lblGrid17, lblGrid18, lblGrid19},
                 new() {lblGrid17, lblGrid18, lblGrid19, lblGrid20},
                 new() {lblGrid18, lblGrid19, lblGrid20, lblGrid21},
                 new() {lblGrid22, lblGrid23, lblGrid24, lblGrid25},
                 new() {lblGrid23, lblGrid24, lblGrid25, lblGrid26},
                 new() {lblGrid24, lblGrid25, lblGrid26, lblGrid27},
                 new() {lblGrid25, lblGrid26, lblGrid27, lblGrid28},
                 new() {lblGrid29, lblGrid30, lblGrid31, lblGrid32},
                 new() {lblGrid30, lblGrid31, lblGrid32, lblGrid33},
                 new() {lblGrid31, lblGrid32, lblGrid33, lblGrid34},
                 new() {lblGrid32, lblGrid33, lblGrid34, lblGrid35},
                 new() {lblGrid36, lblGrid37, lblGrid38, lblGrid39},
                 new() {lblGrid37, lblGrid38, lblGrid39, lblGrid40},
                 new() {lblGrid38, lblGrid39, lblGrid40, lblGrid41},
                 new() {lblGrid39, lblGrid40, lblGrid41, lblGrid42},
                 new() {lblGrid39, lblGrid31, lblGrid23, lblGrid15},
                 new() {lblGrid40, lblGrid32, lblGrid24, lblGrid16},
                 new() {lblGrid32, lblGrid24, lblGrid16, lblGrid8},
                 new() {lblGrid41, lblGrid33, lblGrid25, lblGrid17},
                 new() {lblGrid33, lblGrid25, lblGrid17, lblGrid9},
                 new() {lblGrid25, lblGrid17, lblGrid9, lblGrid1},
                 new() {lblGrid42, lblGrid34, lblGrid26, lblGrid18},
                 new() {lblGrid34, lblGrid26, lblGrid18, lblGrid10},
                 new() {lblGrid26, lblGrid18, lblGrid10, lblGrid2},
                 new() {lblGrid35, lblGrid27, lblGrid19, lblGrid11},
                 new() {lblGrid27, lblGrid19, lblGrid11, lblGrid3},
                 new() {lblGrid28, lblGrid20, lblGrid12, lblGrid4},
                 new() {lblGrid39, lblGrid33, lblGrid27, lblGrid21},
                 new() {lblGrid38, lblGrid32, lblGrid26, lblGrid20},
                 new() {lblGrid32, lblGrid26, lblGrid20, lblGrid14},
                 new() {lblGrid37, lblGrid31, lblGrid25, lblGrid19},
                 new() {lblGrid31, lblGrid25, lblGrid19, lblGrid13},
                 new() {lblGrid25, lblGrid19, lblGrid13, lblGrid7},
                 new() {lblGrid36, lblGrid30, lblGrid24, lblGrid18},
                 new() {lblGrid30, lblGrid24, lblGrid18, lblGrid12},
                 new() {lblGrid24, lblGrid18, lblGrid12, lblGrid6},
                 new() {lblGrid29, lblGrid23, lblGrid17, lblGrid11},
                 new() {lblGrid23, lblGrid17, lblGrid11, lblGrid5},
                 new() {lblGrid22, lblGrid16, lblGrid10, lblGrid4},
                  new() {lblGrid36, lblGrid29, lblGrid22, lblGrid15},
                 new() {lblGrid29, lblGrid22, lblGrid15,lblGrid8},
                 new() {lblGrid22, lblGrid15, lblGrid8, lblGrid1},
                 new() {lblGrid37, lblGrid30, lblGrid23, lblGrid16},
                 new() {lblGrid30, lblGrid23, lblGrid16, lblGrid9},
                 new() {lblGrid23, lblGrid16, lblGrid9, lblGrid2},
                 new() {lblGrid38, lblGrid31, lblGrid24, lblGrid17},
                 new() {lblGrid31, lblGrid24, lblGrid17, lblGrid10},
                 new() {lblGrid24, lblGrid17, lblGrid10, lblGrid3},
                 new() {lblGrid39, lblGrid32, lblGrid25, lblGrid18},
                 new() {lblGrid32, lblGrid25, lblGrid18, lblGrid11},
                 new() {lblGrid25, lblGrid18, lblGrid11, lblGrid4},
                 new() {lblGrid40, lblGrid33, lblGrid26, lblGrid19},
                 new() {lblGrid33, lblGrid26, lblGrid19, lblGrid12},
                 new() {lblGrid26, lblGrid19, lblGrid12, lblGrid5},
                 new() {lblGrid41, lblGrid34, lblGrid27, lblGrid20},
                 new() {lblGrid34, lblGrid27, lblGrid20, lblGrid13},
                 new() {lblGrid27, lblGrid20, lblGrid13, lblGrid6},
                 new() {lblGrid42, lblGrid35, lblGrid28, lblGrid21},
                 new() {lblGrid35, lblGrid28, lblGrid21, lblGrid14},
                 new() {lblGrid28, lblGrid21, lblGrid14, lblGrid7},
        };

            lstbuttons = new() { btnEnter1, btnEnter2, btnEnter3, btnEnter4, btnEnter5, btnEnter6, btnEnter7 };

            btnStart.Click += BtnStart_Click;
            lstbuttons.ForEach(b => b.Click += B_Click);

            DisplayGameStatus();
            SetButtonBackcolor(lstbuttons);
        }

        private void DoTurn(List<Label> lst)
        {
            if (gamestatus == GameStatusenum.Playing)
            {
                var lbl = lst.FirstOrDefault(l => l.BackColor == Color.White);
                if (lbl != null && lbl.BackColor == Color.White)
                {
                    SetLabelBackcolor(lbl);
                    lstwinningsets.ForEach(l => DetectWinner(l));
                    if (gamestatus == GameStatusenum.Playing)
                    {
                        DetectTie();
                        if (gamestatus == GameStatusenum.Playing)
                        {
                            if (currentturn == TurnEnum.Red)
                            {
                                currentturn = TurnEnum.Yellow;
                            }
                            else
                            {
                                currentturn = TurnEnum.Red;
                            }
                            if (IsComputerTurn())
                            {
                                DoComputerTurnOffenceDeffence("Color [Yellow]");

                                if (IsComputerTurn())
                                {
                                    DoComputerTurnOffenceDeffence("Color [Red]");

                                        if (IsComputerTurn())
                                        {
                                            DoComputerTurnSecondOffenceDeffence("Color [Red]");

                                        if (IsComputerTurn())
                                        {
                                            DoComputerTurnSecondOffenceDeffence("Color [Yellow]");

                                                if (IsComputerTurn())
                                            {
                                                DoComputerTurnThirdOffenceDeffence("Color [Yellow]");
                                             
                                                    if (IsComputerTurn())
                                                    {
                                                        DoComputerTurnRandom();
                                                    }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                SetButtonBackcolor(lstbuttons);
                DisplayGameStatus();
            }
        }

        private void GetColumn(Button btn)
        {
            List<Label> lst = new();
            if (btn == btnEnter1)
            {
                lst = lstl1;
            }
            else if (btn == btnEnter2)
            {
                lst = lstl2;
            }
            else if (btn == btnEnter3)
            {
                lst = lstl3;
            }
            else if (btn == btnEnter4)
            {
                lst = lstl4;
            }
            else if (btn == btnEnter5)
            {
                lst = lstl5;
            }
            else if (btn == btnEnter6)
            {
                lst = lstl6;
            }
            else if (btn == btnEnter7)
            {
                lst = lstl7;
            }
            DoTurn(lst);
        }

        private bool IsComputerTurn()
        {
            return currentturn == TurnEnum.Yellow && gamestatus == GameStatusenum.Playing && playcomputer == true;
        }

        private void DoComputerTurnOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 3 && s.Count(l => l.BackColor == Color.White) == 1);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == Color.White);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetButton(lbl);
                }
                
            }
        }

        private void DoComputerTurnSecondOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 2 && s.Count(l => l.BackColor == Color.White) == 2);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == Color.White);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetButton(lbl);
                }
            }
        }

        private void DoComputerTurnThirdOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 1 && s.Count(l => l.BackColor == Color.White) == 3);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == Color.White);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetButton(lbl);
                }
            }
        }

        private void DoComputerTurnRandom()
        {
            var btn = lstbuttons[new Random().Next(0, lstbuttons.Count())];
            GetColumn(btn);

        }

        private void GetButton(Label lbl)
        {
            if (lstl1.Contains(lbl))
            {
                if(lbl == lstl1.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter1);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl2.Contains(lbl))
            {
                if (lbl == lstl2.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter2);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl3.Contains(lbl))
            {
                if (lbl == lstl3.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter3);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl4.Contains(lbl))
            {
                if (lbl == lstl4.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter4);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl5.Contains(lbl))
            {
                if (lbl == lstl5.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter5);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl6.Contains(lbl))
            {
                if (lbl == lstl6.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter5);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
            else if (lstl7.Contains(lbl))
            {
                if (lbl == lstl7.FirstOrDefault(l => l.BackColor == Color.White))
                {
                    GetColumn(btnEnter6);
                }
                else
                {
                    currentturn = TurnEnum.Yellow;
                }
            }
        }

        private void DetectWinner(List<Label> lst)
        {
            if (lst.Count(l => l.BackColor.ToString() == GetLabelBackcolor()) == lst.Count())
            {
                gamestatus = GameStatusenum.Winner;
                SetButtonBackcolor(lstbuttons);
                lst.ForEach(l => l.Text = "W");

            }
        }

        private void DetectTie()
        {
            if (lstlabels.Count(l => l.BackColor == Color.White) == 0)
            {
                gamestatus = GameStatusenum.Tie;
                SetButtonBackcolor(lstbuttons);
                foreach (Label lbl in lstlabels)
                {
                    SetLabelBackcolor(lbl);
                }
            }
        }

        private string GetLabelBackcolor()
        {
            string s = "Color [Red]";
            if (currentturn == TurnEnum.Yellow)
            {
                s = "Color [Yellow]";
            }
            return s;
        }

        private void SetLabelBackcolor(Label lbl)
        {
            Color c = Color.White;
            switch (gamestatus)
            {
                case GameStatusenum.Playing:
                    switch (currentturn)
                    {
                        case TurnEnum.Red:
                            c = Color.Red;
                            break;
                        case TurnEnum.Yellow:
                            c = Color.Yellow;
                            break;
                    }
                    break;
                case GameStatusenum.Tie:
                    c = Color.LimeGreen;
                    break;
            }
            lbl.BackColor = c;
        }

        private void SetButtonBackcolor(List<Button> lst)
        {
            Color c = Color.White;
            switch (gamestatus)
            {
                case GameStatusenum.Playing:
                    switch (currentturn)
                    {
                        case TurnEnum.Red:
                            c = Color.Red;
                            break;
                        case TurnEnum.Yellow:
                            c = Color.Yellow;
                            break;
                    }
                    break;
                case GameStatusenum.Tie:
                    c = Color.LimeGreen;
                    break;
            }
            lst.ForEach(b => b.BackColor = c);
        }

        private void DisplayGameStatus()
        {
            string msg = "Click start to begin Game";
            switch (gamestatus)
            {
                case GameStatusenum.Playing:
                    msg = "Current Turn: " + currentturn.ToString();
                    break;
                case GameStatusenum.Tie:
                    msg = "Tie";
                    break;
                case GameStatusenum.Winner:
                    msg = "Winner is: " + currentturn.ToString();
                    break;
            }
            msg = (playcomputer ? optPlayAgainstComputer.Text : opt2Player.Text) + " - " + msg;

            lblStatus.Text = msg;
        }

        private void StartGame()
        {
            foreach (Label lbl in lstlabels)
            {
                lbl.BackColor = Color.White;
                lbl.Text = "";
            }
            gamestatus = GameStatusenum.Playing;
            currentturn = TurnEnum.Red;
            playcomputer = optPlayAgainstComputer.Checked;
            DisplayGameStatus();
            SetButtonBackcolor(lstbuttons);
        }


        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                GetColumn((Button)sender);
            }

        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
