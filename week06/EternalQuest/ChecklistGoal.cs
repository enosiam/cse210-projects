namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount = 0, int bonusPoints = 0)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _currentCount = currentCount;
            _bonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            _currentCount++;
        }

        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }

        public override string GetStringRepresentation()
        {
            return $"[Checklist Goal] {_name} ({_description}) - {_currentCount}/{_targetCount} completions - Bonus: {_bonusPoints}";
        }

        public override string Serialize()
        {
            return base.Serialize() + $"|{_targetCount}|{_currentCount}|{_bonusPoints}";
        }
    }
}
