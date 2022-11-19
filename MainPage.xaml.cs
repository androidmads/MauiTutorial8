namespace MauiTutorial8;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		level2.Text = Preferences.Get("savekey", "Default Value");
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Preferences.Set("savekey", "New Value");
		level2.Text = Preferences.Get("savekey", "Default Value");
        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

