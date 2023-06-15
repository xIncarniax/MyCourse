using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiCalendar;

public partial class JournalPage : ContentPage, IQueryAttributable, INotifyPropertyChanged
{
    public string DateValue { get; private set; }
    public string TitleValue { get; private set; }
    public List<Exercise> ExerciseList { get; private set; }

    public List<JournalNote> JournalNotes = new();
    public ObservableCollection<JournalNote> Notes = new();

    private string filepath;

    public JournalPage()
    {
        InitializeComponent();

        filepath = Path.Combine(FileSystem.AppDataDirectory, "journal_notes.json");

        if (File.Exists(filepath))
        {
            string journalNotesJson = File.ReadAllText(filepath);
            Notes = JsonConvert.DeserializeObject<ObservableCollection<JournalNote>>(journalNotesJson);
        }
        else
        {
            Notes = new ObservableCollection<JournalNote>();
        }

        journalListView.ItemsSource = Notes;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        DateValue = query["date"] as string;
        TitleValue = Uri.UnescapeDataString(query["trainingName"] as string);
        string exercisesNumberValue = query["exerciseList"] as string;
        string exerciseNumberUri = Uri.UnescapeDataString(exercisesNumberValue);
        ExerciseList = JsonConvert.DeserializeObject<List<Exercise>>(Uri.UnescapeDataString(exerciseNumberUri));

        AssignValue();
    }

    public void AssignValue()
    {
        Notes.Add(new JournalNote()
        {
            Date = DateValue,
            Title = TitleValue,
            ExerciseNumber = ExerciseList.Count.ToString()
        });
        headerLabel.IsVisible = !Notes.Any();

        SaveNotes();
    }

    private void SaveNotes()
    {
        string journalNotesJson = JsonConvert.SerializeObject(Notes.ToList());
        File.WriteAllText(filepath, journalNotesJson);
    }

    private async void DeleteNote(object sender, EventArgs e)
    {
        bool result = await DisplayAlert("Удалить тренировку", "Хотите удалить тренировку?", "Да", "Нет");
        if (result && sender is MenuItem menuItem && menuItem.BindingContext is JournalNote note)
        {
            Notes.Remove(note);
            SaveNotes();
        }
        else
        {
            return;
        }
        headerLabel.IsVisible = !Notes.Any();
    }
}