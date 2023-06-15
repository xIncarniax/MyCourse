namespace MauiCalendar;

public partial class TrainingPage : ContentPage
{
    public TrainingPage()
    {
        InitializeComponent();
    }

    private void ShoulderListSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedExercise = (Exercise)e.SelectedItem;

        MessagingCenter.Send(this, "ExerciseSelected", selectedExercise);
        Navigation.PopAsync();
    }

    private void ChestListSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedExercise = (Exercise)e.SelectedItem;

        MessagingCenter.Send(this, "ExerciseSelected", selectedExercise);
        Navigation.PopAsync();
    }
}