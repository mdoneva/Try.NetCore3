﻿using System;

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

        static Probability IsItDrinkingNight(WeekDay weekDay) =>
            weekDay switch
            {
                WeekDay.Monday => Probability.No,
                WeekDay.Tuesday => Probability.Maybe,
                WeekDay.Wednesday => Probability.Surely,
                WeekDay.Thursday => Probability.No,
                _ => Probability.Surely
            };

        static void Main(string[] args)
        {
            foreach (var day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine($@"Will I drink on {day}?
                                    Answer: {IsItDrinkingNight((WeekDay)day)}");
            }
        }
    }
}