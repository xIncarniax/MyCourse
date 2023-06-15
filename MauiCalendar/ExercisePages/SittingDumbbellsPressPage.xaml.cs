namespace MauiCalendar;

public partial class SittingDumbbellsPressPage : ContentPage
{
	public SittingDumbbellsPressPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=MT0Z1J6TPKE");
    }
}