using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class Client : Agent
    {
        public double ArrivalTime { get; set; }
        public double ServiceTime { get; set; }
        public Client(double customerArrivalTime)
        {
            ArrivalTime = customerArrivalTime;
        }
    }
}