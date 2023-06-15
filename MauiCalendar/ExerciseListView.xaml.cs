namespace MyCourse;

public partial class ExerciseListView : ContentPage
{
	public ExerciseListView()
	{
		InitializeComponent();
	}

    private async void BenchPressTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BenchPressPage());
    }

    private async void BenchDumbbellsTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BenchDumbbellsPage());
    }

    private async void WiringDumbbellsTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WiringDumbbellsPage());
    }

    private async void SittingBenchPressTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SittingBenchPressPage());
    }

    private async void SittingDumbbellsPressTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SittingDumbbellsPressPage());
    }

    private async void SwingDumbbellsTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SwingDumbbellsPage());
    }
}