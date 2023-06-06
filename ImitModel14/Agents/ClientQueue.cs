using System.Collections.Generic;
using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14.Agents
{
    public class ClientQueue : Agent
    {
        public bool HasClients { get; set; }
        private readonly Queue<Client> _clients;

        public ClientQueue()
        {
            _clients = new Queue<Client>();
            HasClients = false;
        }

        public void EnqueueClient(Client client)
        {
            _clients.Enqueue(client);
            HasClients = true;
        }

        public Client DequeueClient()
        {
            var client = _clients.Dequeue();
            if (client == null)
            {
                HasClients = false;
                return null;
            }
            return client;
        }
    }
}