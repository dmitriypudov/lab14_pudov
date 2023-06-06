using System.Collections.Generic;
using System.Linq;
using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class Service : Agent
    {
        private readonly List<WardrobeAttendant> _attendants;
        public bool HasFreeAttendant { get; set; }
        
        public Service(int attendantQuantity, double attendantLambda, Theater theater)
        {
            _attendants = new List<WardrobeAttendant>();
            for (var i = 0; i < attendantQuantity; i++)
            {
                _attendants.Add(new WardrobeAttendant(attendantLambda, theater));
            }

            HasFreeAttendant = true;
        }

        public override double GetNextEventTime()
        {
            return _attendants.Select(attendant => attendant.GetNextEventTime()).Min();
        }

        public void HandleClient(Client client)
        {
            if (client != null)
            {
                var wardrobeAttendant = FindFreeAttendant();
                wardrobeAttendant?.AcceptClient(client);
            }
        }

        private WardrobeAttendant FindFreeAttendant()
        {
            return _attendants.FirstOrDefault(wardrobeAttendant => wardrobeAttendant.IsFree);
        }
    }
}