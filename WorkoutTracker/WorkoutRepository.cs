using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WorkoutTracker
{
    public class WorkoutRepository
    {
        private string _currentUsername = "DefaultUser";

        public void SetUser(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                _currentUsername = username.Trim();
            }
        }

        private string GetFilePath()
        {
            return $"workouts_{_currentUsername}.json";
        }

        public List<Workout> Load()
        {
            string path = GetFilePath();
            if (!File.Exists(path))
                return new List<Workout>();

            try
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Workout>>(json) ?? new List<Workout>();
            }
            catch
            {
                return new List<Workout>();
            }
        }

        public void Save(List<Workout> workouts)
        {
            string path = GetFilePath();
            string json = JsonSerializer.Serialize(workouts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
}