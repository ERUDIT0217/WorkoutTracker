using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WorkoutTracker
{
    public class WorkoutRepository
    {
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonOptions;
        public WorkoutRepository(string filePath = "workout.json")
        {
            _filePath = filePath;
            _jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }
        
        public void Save(List<Workout> workouts)
        {
            string jsonString = JsonSerializer.Serialize(workouts, _jsonOptions);
            File.WriteAllText(_filePath, jsonString);
        }

        public List<Workout> Load()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Workout>();
            }

            string jsonString = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(jsonString)) {
                return new List<Workout>();
            }

            var workouts = JsonSerializer.Deserialize<List<Workout>>(jsonString, _jsonOptions);
            return workouts ?? new List<Workout>();
        }
    }
    
}
