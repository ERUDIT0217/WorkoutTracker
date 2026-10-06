using System;

namespace WorkoutTracker
{
    public class CardioWorkout : Workout
    {
        private double _distanceKm;
        public string ActivityType { get; set; } = "Running";
        public double DistanceKm
        {
            get => _distanceKm;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Дистанція не може бути від'ємною.");
                _distanceKm = value;
            }
        }
        public CardioWorkout() : base() { }
        public CardioWorkout(string title, DateTime date, int durationInMinutes, double userWeightKg, string activityType, double distanceKm) : base(title, date, durationInMinutes, userWeightKg)
        {
            ActivityType = activityType;
            DistanceKm = distanceKm;
        }
        public override double CalculateCaloriesBurned()
        {
            double met = ActivityType switch
            {
                "Плавання" => 8.0,
                "Велосипед" => 7.5,
                "Ходьба" => 3.5,
                _ => 9.8
            };

            return (met * 3.5 * UserWeightKg / 200.0) * DurationInMinutes;
        }
        public override string GetDetails()
        {
            return $"{ActivityType}, Дистанція: {DistanceKm:F2} км, Спалено: {CalculateCaloriesBurned():F0} ккал.";
        }

        public override string TypeTitle => "Кардіо";
        public override string Details => $"Дистанція: {DistanceKm} км";
    }
}
