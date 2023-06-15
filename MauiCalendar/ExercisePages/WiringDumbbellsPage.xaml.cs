namespace MauiCalendar;

public partial class WiringDumbbellsPage : ContentPage
{
	public WiringDumbbellsPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=QaJcczm4uZU");
    }
}