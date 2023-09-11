using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConnectFourSystem
{
    public class Game : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? ScoreChanged;
        public enum GameStatusEnum { NotStarted, Playing, Winner, Tie }

        public enum TurnEnum { None, Red, Yellow }

        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;
        TurnEnum _currentturn = TurnEnum.None;

        List<List<Token>> lstwinningsets;

        List<Token> lstl1;
        List<Token> lstl2;
        List<Token> lstl3;
        List<Token> lstl4;
        List<Token> lstl5;
        List<Token> lstl6;
        List<Token> lstl7;

        private static int scoreredwins;
        private static int scoreyellowwins;
        private static int scorereties;
        private static int numgames;

        public Game()
        {
            numgames++;
            this.GameName = "Game " + numgames;
            for (int i = 0; i < 42; i++)
            {
                this.Tokens.Add(new Token());
            }
            this.Tokens.ForEach(t => t.BackColor = BackColorNotStarted);
            for (int i = 0; i < 7; i++)
            {
                this.EnterButtons.Add(new EnterButton());
            }
            lstl1 = new() { this.Tokens[35], this.Tokens[28], this.Tokens[21], this.Tokens[14], this.Tokens[7], this.Tokens[0] };
            lstl2 = new() { this.Tokens[36], this.Tokens[29], this.Tokens[22], this.Tokens[15], this.Tokens[8], this.Tokens[1] };
            lstl3 = new() { this.Tokens[37], this.Tokens[30], this.Tokens[23], this.Tokens[16], this.Tokens[9], this.Tokens[2] };
            lstl4 = new() { this.Tokens[38], this.Tokens[31], this.Tokens[24], this.Tokens[17], this.Tokens[10], this.Tokens[3] };
            lstl5 = new() { this.Tokens[39], this.Tokens[32], this.Tokens[25], this.Tokens[18], this.Tokens[11], this.Tokens[4] };
            lstl6 = new() { this.Tokens[40], this.Tokens[33], this.Tokens[26], this.Tokens[19], this.Tokens[12], this.Tokens[5] };
            lstl7 = new() { this.Tokens[41], this.Tokens[34], this.Tokens[27], this.Tokens[20], this.Tokens[13], this.Tokens[6] };

            lstwinningsets = new()
            {
                 new() { this.Tokens[36], this.Tokens[37], this.Tokens[38], this.Tokens[35]},
                 new() { this.Tokens[37], this.Tokens[38], this.Tokens[39], this.Tokens[36]},
                 new() { this.Tokens[38], this.Tokens[39], this.Tokens[40], this.Tokens[37]},
                 new() { this.Tokens[39], this.Tokens[40], this.Tokens[41], this.Tokens[38]},

                 new() {this.Tokens[0], this.Tokens[1], this.Tokens[2], this.Tokens[3]},
                 new() {this.Tokens[1], this.Tokens[2], this.Tokens[3], this.Tokens[4]},
                 new() {this.Tokens[2], this.Tokens[3], this.Tokens[4], this.Tokens[5]},
                 new() {this.Tokens[3], this.Tokens[4], this.Tokens[5], this.Tokens[6]},
                 new() {this.Tokens[7], this.Tokens[8], this.Tokens[9], this.Tokens[10]},
                 new() {this.Tokens[8], this.Tokens[9], this.Tokens[10], this.Tokens[11]},
                 new() {this.Tokens[9], this.Tokens[10], this.Tokens[11], this.Tokens[12]},
                 new() {this.Tokens[10], this.Tokens[11], this.Tokens[12], this.Tokens[13]},
                 new() {this.Tokens[14], this.Tokens[15], this.Tokens[16], this.Tokens[17]},
                 new() {this.Tokens[15], this.Tokens[16], this.Tokens[17], this.Tokens[18]},
                 new() {this.Tokens[16], this.Tokens[17], this.Tokens[18], this.Tokens[19]},
                 new() {this.Tokens[17], this.Tokens[18], this.Tokens[19], this.Tokens[20]},
                 new() {this.Tokens[21], this.Tokens[22], this.Tokens[23], this.Tokens[24]},
                 new() {this.Tokens[22], this.Tokens[23], this.Tokens[24], this.Tokens[25]},
                 new() {this.Tokens[23], this.Tokens[24], this.Tokens[25], this.Tokens[26]},
                 new() {this.Tokens[24], this.Tokens[25], this.Tokens[26], this.Tokens[27]},
                 new() {this.Tokens[28], this.Tokens[29], this.Tokens[30], this.Tokens[31]},
                 new() {this.Tokens[29], this.Tokens[30], this.Tokens[31], this.Tokens[32]},
                 new() {this.Tokens[30], this.Tokens[31], this.Tokens[32], this.Tokens[33]},
                 new() {this.Tokens[31], this.Tokens[32], this.Tokens[33], this.Tokens[34]},
                 new() {this.Tokens[35], this.Tokens[36], this.Tokens[37], this.Tokens[38]},
                 new() {this.Tokens[36], this.Tokens[37], this.Tokens[38], this.Tokens[39]},
                 new() {this.Tokens[37], this.Tokens[38], this.Tokens[39], this.Tokens[40]},
                 new() {this.Tokens[38], this.Tokens[39], this.Tokens[40], this.Tokens[41]},
                 new() {this.Tokens[38], this.Tokens[30], this.Tokens[22], this.Tokens[14]},
                 new() {this.Tokens[39], this.Tokens[31], this.Tokens[23], this.Tokens[15]},
                 new() {this.Tokens[31], this.Tokens[23], this.Tokens[15], this.Tokens[7]},
                 new() {this.Tokens[40], this.Tokens[32], this.Tokens[24], this.Tokens[16]},
                 new() {this.Tokens[32], this.Tokens[24], this.Tokens[16], this.Tokens[8]},
                 new() {this.Tokens[24], this.Tokens[16], this.Tokens[8], this.Tokens[0]},
                 new() {this.Tokens[41], this.Tokens[33], this.Tokens[25], this.Tokens[17]},
                 new() {this.Tokens[33], this.Tokens[25], this.Tokens[17], this.Tokens[9]},
                 new() {this.Tokens[25], this.Tokens[17], this.Tokens[9], this.Tokens[1]},
                 new() {this.Tokens[34], this.Tokens[26], this.Tokens[18], this.Tokens[10]},
                 new() {this.Tokens[26], this.Tokens[18], this.Tokens[10], this.Tokens[2]},
                 new() {this.Tokens[27], this.Tokens[19], this.Tokens[11], this.Tokens[3]},
                 new() {this.Tokens[38], this.Tokens[32], this.Tokens[26], this.Tokens[20]},
                 new() {this.Tokens[37], this.Tokens[31], this.Tokens[25], this.Tokens[19]},
                 new() {this.Tokens[31], this.Tokens[25], this.Tokens[19], this.Tokens[13]},
                 new() {this.Tokens[36], this.Tokens[30], this.Tokens[24], this.Tokens[18]},
                 new() {this.Tokens[30], this.Tokens[24], this.Tokens[18], this.Tokens[12]},
                 new() {this.Tokens[24], this.Tokens[18], this.Tokens[12], this.Tokens[6]},
                 new() {this.Tokens[35], this.Tokens[29], this.Tokens[23], this.Tokens[17]},
                 new() {this.Tokens[29], this.Tokens[23], this.Tokens[17], this.Tokens[11]},
                 new() {this.Tokens[23], this.Tokens[17], this.Tokens[11], this.Tokens[5]},
                 new() {this.Tokens[28], this.Tokens[22], this.Tokens[16], this.Tokens[10]},
                 new() {this.Tokens[22], this.Tokens[16], this.Tokens[10], this.Tokens[4]},
                 new() {this.Tokens[21], this.Tokens[15], this.Tokens[9], this.Tokens[3]},
                 new() {this.Tokens[35], this.Tokens[28], this.Tokens[21], this.Tokens[14]},
                 new() {this.Tokens[28], this.Tokens[21], this.Tokens[14],this.Tokens[7]},
                 new() {this.Tokens[21], this.Tokens[14], this.Tokens[7], this.Tokens[0]},
                 new() {this.Tokens[36], this.Tokens[29], this.Tokens[22], this.Tokens[15]},
                 new() {this.Tokens[29], this.Tokens[22], this.Tokens[15], this.Tokens[8]},
                 new() {this.Tokens[22], this.Tokens[15], this.Tokens[8], this.Tokens[1]},
                 new() {this.Tokens[37], this.Tokens[30], this.Tokens[23], this.Tokens[16]},
                 new() {this.Tokens[30], this.Tokens[23], this.Tokens[16], this.Tokens[9]},
                 new() {this.Tokens[23], this.Tokens[16], this.Tokens[9], this.Tokens[2]},
                 new() {this.Tokens[38], this.Tokens[31], this.Tokens[24], this.Tokens[17]},
                 new() {this.Tokens[31], this.Tokens[24], this.Tokens[17], this.Tokens[10]},
                 new() {this.Tokens[24], this.Tokens[17], this.Tokens[10], this.Tokens[3]},
                 new() {this.Tokens[39], this.Tokens[32], this.Tokens[25], this.Tokens[18]},
                 new() {this.Tokens[32], this.Tokens[25], this.Tokens[18], this.Tokens[11]},
                 new() {this.Tokens[25], this.Tokens[18], this.Tokens[11], this.Tokens[4]},
                 new() {this.Tokens[40], this.Tokens[33], this.Tokens[26], this.Tokens[19]},
                 new() {this.Tokens[33], this.Tokens[26], this.Tokens[19], this.Tokens[12]},
                 new() {this.Tokens[26], this.Tokens[19], this.Tokens[12], this.Tokens[5]},
                 new() {this.Tokens[41], this.Tokens[34], this.Tokens[27], this.Tokens[20]},
                 new() {this.Tokens[34], this.Tokens[27], this.Tokens[20], this.Tokens[13]},
        };
        }



        public List<Token> Tokens { get; private set; } = new();
        public List<EnterButton> EnterButtons { get; private set; } = new();
        public string GameName { get; private set; }
        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
                this.InvokePropertyChanged("StartButtonText");
            }
        }

        public TurnEnum CurrentTurn
        {
            get => _currentturn;
            private set
            {
                _currentturn = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
            }
        }

        public string GameStatusDescription
        {
            get
            {
                string s = $"{this.GameName}, {this.GameMode}: ";

                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + " Click Start";
                        break;
                    case GameStatusEnum.Playing:
                        s = s + " Current Turn" + this.CurrentTurn;
                        break;
                    case GameStatusEnum.Winner:
                        s = s + this.GameStatus + " is " + this.CurrentTurn;
                        break;
                    case GameStatusEnum.Tie:
                        s = s + this.GameStatus;
                        break;
                }
                return s;
            }
        }
        public TurnEnum Winner { get; private set; }
        public bool PlayAgainstComputer { get; set; }
        public string GameMode { get => this.PlayAgainstComputer ? "Play the Computer" : "2 Player"; }
        public string GameModeHeader { get => "For " + this.GameName; }
        public string StartButtonText
        {
            get
            {
                string s = "";
                if (this.GameStatus == GameStatusEnum.NotStarted)
                {
                    s = "Start ";
                }
                else
                {
                    s = "Stop ";
                }
                s = s + this.GameName;
                return s;
            }
        }
        public System.Drawing.Color BackColorNotStarted { get; set; } = System.Drawing.Color.White;
        public System.Drawing.Color BackColorTie { get; set; } = System.Drawing.Color.LimeGreen;
        public System.Drawing.Color BackColorCurrentTurnRed { get; set; } = System.Drawing.Color.Red;
        public System.Drawing.Color BackColorCurrentTutnYellow { get; set; } = System.Drawing.Color.Yellow;
        public string TokenWinnerText { get; set; } = "W";
        public string TokenPlayingText { get; set; } = "";
        public static string Score { get => $"Red wins = {scoreredwins}, Yellow wins =  {scoreyellowwins}, Ties = {scorereties}"; }

        public void StartGame(bool playagainstcomputer = false)
        {
            this.PlayAgainstComputer = playagainstcomputer;
            ClearTokens();
            this.EnterButtons.ForEach(t => t.BackColor = this.BackColorCurrentTurnRed);
            this.GameStatus = GameStatusEnum.Playing;
            this.CurrentTurn = TurnEnum.Red;
        }

        public void StopGame()
        {
            this.GameStatus = GameStatusEnum.NotStarted;
            this.EnterButtons.ForEach(b => b.BackColor = BackColorNotStarted);
            ClearTokens();
        }

        private void ClearTokens()
        {
            this.Tokens.ForEach(t => { t.BackColor = this.BackColorNotStarted; t.DeclareWinnerText = TokenPlayingText; });

        }

        private void TakeToken(List<Token> lst)
        {
            if (this.GameStatus == GameStatusEnum.Playing)
            {
                var lbl = lst.FirstOrDefault(l => l.BackColor == BackColorNotStarted);
                if (lbl != null && lbl.BackColor == BackColorNotStarted)
                {
                    if (CurrentTurn == TurnEnum.Red)
                    {
                        lbl.BackColor = BackColorCurrentTurnRed;
                        this.EnterButtons.ForEach(b => b.BackColor = BackColorCurrentTutnYellow);
                    }
                    else
                    {
                        lbl.BackColor = BackColorCurrentTutnYellow;

                        this.EnterButtons.ForEach(b => b.BackColor = BackColorCurrentTurnRed);
                    }

                    lstwinningsets.ForEach(l => DetectWinner(l));
                    if (this.GameStatus == GameStatusEnum.Playing)
                    {
                        DetectTie();
                        if (this.CurrentTurn == TurnEnum.Red)
                        {
                            this.CurrentTurn = TurnEnum.Yellow;
                        }
                        else
                        {
                            this.CurrentTurn = TurnEnum.Red;
                        }
                        if (IsComputerTurn())
                        {
                            DoComputerTurn();
                        }
                    }
                }
            }
        }

        public void GetColumn(int buttonnum)
        {
            List<Token> lst = new();
            if (buttonnum == 0)
            {
                lst = lstl1;
            }
            else if (buttonnum == 1)
            {
                lst = lstl2;
            }
            else if (buttonnum == 2)
            {
                lst = lstl3;
            }
            else if (buttonnum == 3)
            {
                lst = lstl4;
            }
            else if (buttonnum == 4)
            {
                lst = lstl5;
            }
            else if (buttonnum == 5)
            {
                lst = lstl6;
            }
            else if (buttonnum == 6)
            {
                lst = lstl7;
            }
            TakeToken(lst);
        }

        private bool IsComputerTurn()
        {
            return this.PlayAgainstComputer == true && this.GameStatus == GameStatusEnum.Playing && this.CurrentTurn == TurnEnum.Yellow;
        }

        private void DoComputerTurn()
        {
            DoComputerTurnOffenceDeffence("Color [Yellow]");

            DoComputerTurnOffenceDeffence("Color [Red]");

            DoComputerTurnSecondOffenceDeffence("Color [Red]");

            DoComputerTurnSecondOffenceDeffence("Color [Yellow]");

            DoComputerTurnThirdOffenceDeffence("Color [Red]");

            DoComputerTurnThirdOffenceDeffence("Color [Yellow]");

            DoComputerTurnRandom();
        }

        private void DoComputerTurnOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 3 && s.Count(l => l.BackColor == BackColorNotStarted) == 1);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == BackColorNotStarted);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == BackColorNotStarted) && IsComputerTurn() == true)
                {
                    GetButton(lbl);
                }

            }
        }

        private void DoComputerTurnSecondOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 2 && s.Count(l => l.BackColor == BackColorNotStarted) == 2);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == BackColorNotStarted);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == BackColorNotStarted) && IsComputerTurn() == true)
                {
                    GetButton(lbl);
                }
            }
        }

        private void DoComputerTurnThirdOffenceDeffence(string turn)
        {
            var lst = lstwinningsets.FirstOrDefault(s => s.Count(l => l.BackColor.ToString() == turn) == 1 && s.Count(l => l.BackColor == BackColorNotStarted) == 3);
            if (lst != null)
            {
                var lbl = lst.First(l => l.BackColor == BackColorNotStarted);
                if (lbl == lst.FirstOrDefault(l => l.BackColor == BackColorNotStarted) && IsComputerTurn() == true)
                {
                    GetButton(lbl);
                }
            }
        }

        private void DoComputerTurnRandom()
        {
            if (IsComputerTurn() == true)
            {
                Random rnd = new();
                int randombtn = rnd.Next(1, 8);
                GetColumn(randombtn);
            }
        }

        private void GetButton(Token token)
        {
            if (lstl1.Contains(token))
            {
                if (token == lstl1.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(0);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl2.Contains(token))
            {
                if (token == lstl2.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(1);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl3.Contains(token))
            {
                if (token == lstl3.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(2);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl4.Contains(token))
            {
                if (token == lstl4.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(3);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl5.Contains(token))
            {
                if (token == lstl5.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(4);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl6.Contains(token))
            {
                if (token == lstl6.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(5);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
            else if (lstl7.Contains(token))
            {
                if (token == lstl7.FirstOrDefault(l => l.BackColor == BackColorNotStarted))
                {
                    GetColumn(6);
                }
                else
                {
                    this.CurrentTurn = TurnEnum.Yellow;
                }
            }
        }

        private void DetectWinner(List<Token> lst)
        {
            if (lst.Count(l => l.BackColor.ToString() == GetLabelBackcolor()) == lst.Count())
            {
                this.GameStatus = GameStatusEnum.Winner;
                this.Winner = this.CurrentTurn;
                this.EnterButtons.ForEach(b => b.BackColor = BackColorNotStarted);
                lst.ForEach(l => l.DeclareWinnerText = TokenWinnerText);
                if (this.CurrentTurn == TurnEnum.Red)
                {
                    scoreredwins++;
                }
                else
                {
                    scoreyellowwins++;
                }
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }

        private string GetLabelBackcolor()
        {
            string s = "Color [Red]";
            if (this.CurrentTurn == TurnEnum.Yellow)
            {
                s = "Color [Yellow]";
            }
            return s;
        }

        private void DetectTie()
        {
            if (this.Tokens.Count(l => l.BackColor == BackColorNotStarted) == 0)
            {
                this.GameStatus = GameStatusEnum.Tie;
                this.Tokens.ForEach(t => t.BackColor = this.BackColorTie);
                this.EnterButtons.ForEach(b => b.BackColor = BackColorTie);
                scorereties++;
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}