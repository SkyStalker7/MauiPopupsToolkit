using CommunityToolkit.Maui.Views;

namespace MauiPopupsToolkit;

public partial class NewPage1: Popup
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();
    }
}