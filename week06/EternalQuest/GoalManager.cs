using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine($"\nScore: {_score}");
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoals(); break;
                    case "3": RecordEvent(); break;
                    case "4": SaveGoals(); break;
                    case "5": LoadGoals(); break;
                    case "6": quit = true; break;
                }
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("Choose goal type: 1. Simple  2. Eternal  3. Checklist");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
                _goals.Add(new SimpleGoal(name, description, points));
            else if (type == "2")
                _goals.Add(new EternalGoal(name, description, points));
            else if (type == "3")
            {
                Console.Write("Target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, 0, bonus));
            }
        }

        private void ListGoals()
        {
            Console.WriteLine("\n--- Goals ---");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
            }
        }

        private void RecordEvent()
        {
            ListGoals();
            Console.Write("Choose goal number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _score += _goals[index].Points;

                if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
                    _score += checklist.Serialize().Split('|').Length > 7 ? int.Parse(checklist.Serialize().Split('|')[7]) : 0;
            }
        }

        private void SaveGoals()
        {
            Console.Write("File name: ");
            string file = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                    writer.WriteLine(goal.Serialize());
            }
            Console.WriteLine("Goals saved.");
        }

        private void LoadGoals()
        {
            Console.Write("File name: ");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                _score = int.Parse(lines[0]);
                _goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                    _goals.Add(Goal.Deserialize(lines[i]));

                Console.WriteLine("Goals loaded.");
            }
            else
                Console.WriteLine("File not found.");
        }
    }
}
