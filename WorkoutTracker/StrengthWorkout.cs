using System;

namespace WorkoutTracker
{
    public class StrengthWorkout : Workout
    {
        private int _sets;
        private int _reps;
        private double _weightLiftedKg;
        public int Sets
        {
            get => _sets;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Кількість підходів повинна бути більшою за нуль.");
                _sets = value;
            }

        }
        public int Reps
        {
            get => _reps;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Кількість повторень повинна бути більшою за нуль.");
                _reps = value;
            }
        }
        public double WeightLiftedKg
        {
            get => _weightLiftedKg;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Робоча вага не може бути від'ємною.");
                _weightLiftedKg = value;
            }
        }

        public StrengthWorkout() : base() { }
        public StrengthWorkout(string title, DateTime date, int durationInMinutes, double userWeightKg, int sets, int reps, double weightliftedKg) : base(title, date, durationInMinutes, userWeightKg)
        {
            Sets = sets;
            Reps = reps;
            WeightLiftedKg = weightliftedKg;
        }

        public override double CalculateCaloriesBurned()
        {
            double weightFactor = 1.0 + (WeightLiftedKg / 100.0) * 0.15;
            double baseMet = 5.0 * weightFactor;

            return (baseMet * 3.5 * UserWeightKg / 200.0) * DurationInMinutes;
        }

        public override string GetDetails()
        {
            return $"Підходи: {Sets}, Повторення: {Reps}, Вага: {WeightLiftedKg:F1} кг, Спалено: {CalculateCaloriesBurned():F0} ккал.";
        }

        public override string TypeTitle => "Силове";
        public override string Details => $"{Sets} підх. × {Reps} повт. ({WeightLiftedKg} кг)";
    }
}
