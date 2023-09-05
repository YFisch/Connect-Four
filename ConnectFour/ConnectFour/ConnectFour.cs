//AS Great job! 95% See one comment below and resubmit.

using ConnectFourSystem;

namespace ConnectFour
{

    public partial class ConnectFour : Form
    {
        Game game = new();

        List<Label> lstlabels;

        List<Button> lstbuttons;

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


            lstbuttons = new() { btnEnter1, btnEnter2, btnEnter3, btnEnter4, btnEnter5, btnEnter6, btnEnter7 };

            btnStart.Click += BtnStart_Click;
            lstbuttons.ForEach( b =>
            {
                b.Click += B_Click;
                b.DataBindings.Add("Backcolor", game.EnterButtons[lstbuttons.IndexOf(b)], "BackColor");
            });

            lstlabels.ForEach(l =>
            {
                Token token = game.Tokens[lstlabels.IndexOf(l)];
                l.DataBindings.Add("Backcolor", token, "Backcolor");
                l.DataBindings.Add("Text", token, "DeclareWinnerText");
            });

            lblStatus.DataBindings.Add("Text", game, "GameStatusDescription");
        }

        private void DoTurn(Button btn)
        {
            int num = lstbuttons.IndexOf(btn);
            game.GetColumn(num);
        }

        private void StartGame()
        {
            game.StartGame(optPlayAgainstComputer.Checked);
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                DoTurn((Button)sender);
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
