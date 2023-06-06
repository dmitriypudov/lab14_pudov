using System;
using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class ClientStream : Agent
    {
        public int TotalClients;
        private Client _client;
        private double _nextCustomerArrivalTime;
        private readonly Random _rnd;
        private readonly double _lambda;
        private readonly Theater _theater;

        public ClientStream(Theater theater, double flowLambda)
        {
            _theater = theater;
            _rnd = new Random();
            _lambda = flowLambda;
            _nextCustomerArrivalTime = SimulateInterArrivalTime();
        }

        private double SimulateInterArrivalTime()
        {
            return -Math.Log(_rnd.NextDouble()) / _lambda;
        }

        public override double GetNextEventTime()
        {
            return _nextCustomerArrivalTime;
        }

        public override void ProcessEvent()
        {
            _client = new Client(_nextCustomerArrivalTime);
            TotalClients++;
            _theater.HandleArrivedClient(_client);
            _nextCustomerArrivalTime += SimulateInterArrivalTime();
        }
    }
}