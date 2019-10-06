using System;

namespace Patterns
{
    public static class Patterns
    {
        public enum Probability
        {
            Surely,
            Maybe,
            No
        }

        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static Probability IsItDrinkingNight(WeekDay weekDay) =>
           weekDay switch
           {
               WeekDay.Tuesday => Probability.Maybe,
               var x when x is WeekDay.Monday || x is WeekDay.Thursday => Probability.No,
               _ => Probability.Surely
           };

        public enum WeatherCondition
        {
            Sunny,
            Rainy,
            Windy,
            Cloudy,
            Snowy
        }

        public enum PlaceToBe
        {
            Beach,
            Mountain,
            Park,
            Work,
            InBed
        }

        static PlaceToBe WhereAmIGoing(WeatherCondition weather, WeekDay weekDay, bool hasVacation) =>
                (weather, weekDay, hasVacation) switch
                {
                    (WeatherCondition.Sunny, WeekDay.Tuesday, true) => PlaceToBe.Beach,
                    (WeatherCondition.Snowy, WeekDay.Friday, true) => PlaceToBe.Mountain,
                    (WeatherCondition.Rainy, WeekDay.Monday, false) => PlaceToBe.Work,
                    (WeatherCondition.Cloudy, _, false) => PlaceToBe.Park,
                    _ => PlaceToBe.InBed
                };

        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine($@"Is it drinking night ({day})?
                                    Answer: {IsItDrinkingNight((WeekDay)day)}");
            }

            Console.WriteLine();

            Console.WriteLine($@"Where am I going on Mondays when it is raining?
                                    Answer: {WhereAmIGoing(WeatherCondition.Rainy, WeekDay.Monday, false)}");
        }
    }
}
