namespace MauiCalendar;

public partial class BenchDumbbellsPage : ContentPage
{
	public BenchDumbbellsPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=mXdyLcQ_VZU");
    }
}