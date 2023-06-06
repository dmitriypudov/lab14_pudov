using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class Theater : Agent
    {
        private readonly Service _service;
        private readonly ClientQueue _clientQueue;

        public Theater(int attendantQuantity, double attendantLambda)
        {
            _service = new Service(attendantQuantity, attendantLambda, this);
            _clientQueue = new ClientQueue();
        }

        public override double GetNextEventTime()
        {
            return _service.GetNextEventTime();
        }

        public override void ProcessEvent()
        {
            _service.HandleClient(HandleClientInQueue());
        }

        public void HandleArrivedClient(Client client)
        {
            if (_service.HasFreeAttendant)
            {
                _service.HandleClient(client);
            }
            else
            {
                _clientQueue.EnqueueClient(client);
            }
        }

        public Client HandleClientInQueue()
        {
            return _clientQueue.HasClients ? _clientQueue.DequeueClient() : null;
        }
    }
}