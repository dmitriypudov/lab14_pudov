using System;
using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class WardrobeAttendant : Agent
    {
        public bool IsFree { get; set; }
        private Client _clientInService;
        private double _endOfServiceTime;
        private readonly Random _rnd;
        private readonly double _lambda;
        private readonly Theater _theater;

        public WardrobeAttendant(double lambda, Theater theater)
        {
            IsFree = true;
            _rnd = new Random();
            _theater = theater;
            _lambda = lambda;
            _endOfServiceTime = double.MaxValue;
        }

        public void AcceptClient(Client client)
        {
            if (IsFree)
            {
                IsFree = false;
                _clientInService = client;
                _endOfServiceTime = Model.Time + SimulateServiceTime();

                ProcessEvent();
            }
        }

        private double SimulateServiceTime()
        {
            return -Math.Log(_rnd.NextDouble()) / _lambda;
        }

        public override double GetNextEventTime()
        {
            _clientInService.ServiceTime = _endOfServiceTime;
            _clientInService = null;
            IsFree = true;

            return _endOfServiceTime;
        }

        public override void ProcessEvent()
        {
            _theater.ProcessEvent();
        }
    }
}