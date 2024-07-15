namespace _2024_T20_Match
{
    public class T20_Model
    {
        public string? Name { get; set; }
        public int Score { get; set; }
    }

    public class CountryData
    {
        public int Play { get; set; }
        public int Wins { get; set; }
        public string? Runs { get; set; }
        public int CatchValue { get; set; }
        public int Score6s { get; set; }
        public int Score4s { get; set; }
        public int Boundaries { get; set; }
        public int Batter { get; set; }
        public string? BatterImage { get; set; }
        public int WicketTaker { get; set; }
        public string? WicketTakerImage { get; set; }
    }
}