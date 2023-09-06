using ConnectFourSystem;

namespace ConnectFourApp;

public partial class ConnectFour : ContentPage
{
    Game game = new();

    List<Label> lstlabels;

    List<Button> lstbuttons;
    public ConnectFour()
	{
		InitializeComponent();
        this.BindingContext = game;

        lstlabels = new() {
            lblGrid1, lblGrid2, lblGrid3, lblGrid4, lblGrid5, lblGrid6, lblGrid7, lblGrid8, lblGrid9,
            lblGrid10, lblGrid11, lblGrid12, lblGrid13, lblGrid14, lblGrid15, lblGrid16, lblGrid17, lblGrid18, lblGrid19,
            lblGrid20, lblGrid21, lblGrid22, lblGrid23, lblGrid24, lblGrid25, lblGrid26, lblGrid27, lblGrid28, lblGrid29,
            lblGrid30, lblGrid31, lblGrid32, lblGrid33, lblGrid34, lblGrid35, lblGrid36, lblGrid37, lblGrid38, lblGrid39,
            lblGrid40, lblGrid41, lblGrid42
            };


        lstbuttons = new() { btnEnter1, btnEnter2, btnEnter3, btnEnter4, btnEnter5, btnEnter6, btnEnter7 };

    }

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        game.StartGame(PlayAgainstComputerRb.IsChecked);
    }

    private void btnEnter_Clicked(object sender, EventArgs e)
    {
        game.GetColumn(lstbuttons.IndexOf((Button)sender));
    }
}