namespace MyCourse;

public partial class SittingBenchPressPage : ContentPage
{
	public SittingBenchPressPage()
	{
		InitializeComponent();
	}

    private async void VideoPreviewTapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/watch?v=82ZYnl0xov8");
    }
}