using CommunityToolkit.Maui.Views;

namespace MauiPopupsToolkit;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    public class Class1 : ContentPage
    {
        public int a;
        public Class1()
        {
            a = 0;
        }
       // Class1 class1 = new Class1();
        public void Schet()
        {
            a++;
            if (a == 2)
            {
                this.ShowPopup(new NewPage1());
            }
        }
    }
    Class1 class1 = new Class1();


    public void OnCounterClicked(object sender, EventArgs e)
	{
        CounterBtn.Text = $"Clicked {class1.a} times";
        class1.Schet();
	}
    public void CounterClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new NewPage1());
    }
}

