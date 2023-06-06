namespace SimulationModel14.Agents.Interfaces
{
    public abstract class Agent
    {
        public virtual double GetNextEventTime()
        {
            return double.MaxValue;
        }

        public virtual void ProcessEvent()
        {

        }
    }
}