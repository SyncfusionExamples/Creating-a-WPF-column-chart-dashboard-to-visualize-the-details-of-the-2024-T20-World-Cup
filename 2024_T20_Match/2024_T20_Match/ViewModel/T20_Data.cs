using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace _2024_T20_Match
{
    public class T20_Data : INotifyPropertyChanged
    {
        private int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                UpdateIndex(value);
                OnPropertyChanged();
            }
        }

        private int play;
        public int Play
        {
            get => play;
            set { play = value; OnPropertyChanged(); }
        }

        private int wins;
        public int Wins
        {
            get => wins;
            set { wins = value; OnPropertyChanged(); }
        }

        private string runs;
        public string Runs
        {
            get => runs;
            set { runs = value; OnPropertyChanged(); }
        }

        private int catchValue;
        public int CatchValue
        {
            get => catchValue;
            set { catchValue = value; OnPropertyChanged(); }
        }

        private int score6s;
        public int Score6s
        {
            get => score6s;
            set { score6s = value; OnPropertyChanged(); }
        }

        private int score4s;
        public int Score4s
        {
            get => score4s;
            set { score4s = value; OnPropertyChanged(); }
        }

        private int boundaries;
        public int Boundaries
        {
            get => boundaries;
            set { boundaries = value; OnPropertyChanged(); }
        }

        private int batter;
        public int Batter
        {
            get => batter;
            set { batter = value; OnPropertyChanged(); }
        }

        private string batterImage;
        public string BatterImage
        {
            get => batterImage;
            set { batterImage = value; OnPropertyChanged(); }
        }

        private int wicketTaker;
        public int WicketTaker
        {
            get => wicketTaker;
            set { wicketTaker = value; OnPropertyChanged(); }
        }

        private string wicketTakerImage;
        public string WicketTakerImage
        {
            get => wicketTakerImage;
            set { wicketTakerImage = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PlayersData> data;
        public ObservableCollection<PlayersData> Data
        {
            get => data;
            set { data = value; OnPropertyChanged(); }
        }

        private Dictionary<string, CountryData> countryData;
        private Dictionary<string, List<PlayersData>> playersData;
        public ObservableCollection<string> CountryOption { get; set; }

        public T20_Data()
        {
            CountryOption = new ObservableCollection<string> { "India", "Ireland", "England", "Pakistan", "Canada", "United States", "Australia", "Scotland", "Oman", "South Africa", "Sri Lanka", "New Zealand", "Afghanistan",
                                                               "Nepal", "West Indies", "Uganda", "Papua New Guinea", "Namibia", "Netherlands", "Bangladesh"};

            var executingAssembly = typeof(App).GetTypeInfo().Assembly;
            using (var stream = executingAssembly.GetManifestResourceStream("_2024_T20_Match.Resources.country_data.json"))
            using (var textStream = new StreamReader(stream))
            {
                countryData = JsonConvert.DeserializeObject<Dictionary<string, CountryData>>(textStream.ReadToEnd().Trim());
            }

            using (var stream = executingAssembly.GetManifestResourceStream("_2024_T20_Match.Resources.players_data.json"))
            using (var textStream = new StreamReader(stream))
            {
                playersData = JsonConvert.DeserializeObject<Dictionary<string, List<PlayersData>>>(textStream.ReadToEnd().Trim());
            }

            SelectedIndex = 0;
        }

        private void UpdateIndex(int value)
        {
            if (value >= 0 && value < CountryOption.Count)
            {
                string selectedCountry = CountryOption[value];
                if (countryData.ContainsKey(selectedCountry))
                {
                    var data = countryData[selectedCountry];
                    Play = data.Play;
                    Wins = data.Wins;
                    Runs = data.Runs;
                    CatchValue = data.CatchValue;
                    Score6s = data.Score6s;
                    Score4s = data.Score4s;
                    Boundaries = data.Boundaries;
                    Batter = data.Batter;
                    BatterImage = data.BatterImage;
                    WicketTaker = data.WicketTaker;
                    WicketTakerImage = data.WicketTakerImage;
                }

                if (playersData.ContainsKey(selectedCountry))
                {
                    Data = new ObservableCollection<PlayersData>(playersData[selectedCountry]);
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}