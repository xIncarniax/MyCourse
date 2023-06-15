namespace MauiCalendar;

public partial class SwingDumbbellsPage : ContentPage
{
	public SwingDumbbellsPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=FTjQO-nE5zw");
    }
}