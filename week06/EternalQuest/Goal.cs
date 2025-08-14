using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public virtual string Serialize()
        {
            return $"{GetType().Name}|{_name}|{_description}|{_points}";
        }

        public static Goal Deserialize(string line)
        {
            string[] parts = line.Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            return type switch
            {
                "SimpleGoal" => new SimpleGoal(name, description, points, bool.Parse(parts[4])),
                "EternalGoal" => new EternalGoal(name, description, points),
                "ChecklistGoal" => new ChecklistGoal(name, description, points,
                                                     int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
                _ => throw new Exception("Unknown goal type")
            };
        }
    }
}
