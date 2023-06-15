using Syncfusion.Maui.Calendar;

namespace MyCourse;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        citate.Text = "                 Готовь тело зимой, \n чтоб летом не стыдно было\n\t\t             (c)Джейсон Стэтхем";
	}

    private async void Calendar_SelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
    {
        var selectedDate = e.NewValue;

        if (selectedDate != null)

        {

            bool result = await DisplayAlert("Добавить тренировку", "Хотите добавить тренировку на этот день?", "Да", "Нет");

            if (result)

            {

                await Navigation.PushAsync(new CreateProgramPage(selectedDate.ToString()));

                Calendar.SelectedDate = null;

            }

            else

            {

                Calendar.SelectedDate = null;

            }

        }

    }
}

