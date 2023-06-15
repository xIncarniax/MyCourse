using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MyCourse;

public partial class CreateProgramPage : ContentPage
{
    public ListView ExercisesListView => exercisesListView;
    public ObservableCollection<Exercise> Exercises { get; set; }

    public List<Exercise> exercisesList = new();

    public CreateProgramPage(string date)
    {
        InitializeComponent();
        dateLabel.Text = date[..10];

        Exercises = new ObservableCollection<Exercise>();
        exercisesListView.ItemsSource = Exercises;

        MessagingCenter.Subscribe<TrainingPage, Exercise>(this, "ExerciseSelected", (sender, selectedExercise) =>
        {
            Exercises.Add(selectedExercise);
            exercisesList.Add(selectedExercise);

            OnPropertyChanged(nameof(Exercises));
        });
    }

    public async void AddButton_Click(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TrainingPage());
    }

    public async void SaveButton_Click(Object sender, EventArgs e)
    {
        //Toast.Make("Сохранено!", ToastDuration.Short, 14).Show();

        string exerciseList = JsonConvert.SerializeObject(exercisesList);
        trainingName.Text ??= "";

        string uri = $"//JournalPage?date={Uri.EscapeDataString(dateLabel.Text)}&trainingName={Uri.EscapeDataString(trainingName.Text)}&exerciseList={Uri.EscapeDataString(exerciseList)}";
        await Shell.Current.GoToAsync(uri);
    }
}