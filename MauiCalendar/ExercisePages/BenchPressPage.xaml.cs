namespace MauiCalendar;

public partial class BenchPressPage : ContentPage
{
	public BenchPressPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=_l1i3UD_59Y");
    }
}