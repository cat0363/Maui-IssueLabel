namespace Maui_IssueLabel;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void txtTest_TextChanged(object sender, TextChangedEventArgs e)
    {
		lblTest.Text = txtTest.Text;
    }
}

