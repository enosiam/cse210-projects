namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            // Never completed — always earns points
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"[Eternal Goal] {_name} ({_description}) - Points per event: {_points}";
        }
    }
}
