namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isComplete = false)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"[Simple Goal] {_name} ({_description}) - Points: {_points} - Completed: {_isComplete}";
        }

        public override string Serialize()
        {
            return base.Serialize() + $"|{_isComplete}";
        }
    }
}
