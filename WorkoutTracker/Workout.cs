using System;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace WorkoutTracker
{
    [JsonDerivedType(typeof(CardioWorkout), typeDiscriminator: "cardio")]
    [JsonDerivedType(typeof(StrengthWorkout), typeDiscriminator: "strength")]
    public abstract class Workout
    {
        private string _title = string.Empty;
        private int _durationInMinutes;
        private double _userWeightKg;

        [DisplayName("Дата")]
        public DateTime Date { get; set; } = DateTime.Now;

        [DisplayName("Назва")]
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва тренування не може бути порожньою.");
                _title = value.Trim();
            }
        }

        [DisplayName("Час, хв")]
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("тривалість має перевищувати 0 хвилин.");
                _durationInMinutes = value;
            }
        }

        [DisplayName("Вага, кг")]
        public double UserWeightKg
        {
            get => _userWeightKg;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Маса тіла повинна бути додатною.");
                _userWeightKg = value;
            }
        }
        protected Workout() { }
        protected Workout(string title, DateTime date, int durationInMinutes, double userWeightKg)
        {
            Title = title;
            Date = date;
            DurationInMinutes = durationInMinutes;
            UserWeightKg = userWeightKg;
        }
        public abstract double CalculateCaloriesBurned();
        public abstract string GetDetails();


        [DisplayName("Тип")]
        public virtual string TypeTitle => "Тренування";

        [DisplayName("Параметри")]
        public virtual string Details => "-";

        [DisplayName("Калорії")]
        public string Calories => $"{CalculateCaloriesBurned():F0} ккал";

        [DisplayName("Статус")]
        public bool IsCompleted { get; set; } = false;
    }
}
