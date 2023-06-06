using System.Collections.Generic;
using SimulationModel14.Agents;
using SimulationModel14.Agents.Interfaces;

namespace SimulationModel14
{
    public class Model
    {
        public Theater Theater { get; }
        public ClientStream Stream { get; }
        public static double Time { get; private set; }
        private readonly double _totalTime;
        private readonly List<Agent> _agents = new();
        
        public Model(double totalTime, int attendantQuantity, double attendantLambda, double flowLambda)
        {
            _totalTime = totalTime;

            Theater = new Theater(attendantQuantity, attendantLambda);
            Stream = new ClientStream(Theater, flowLambda);

            _agents.Add(Stream);
            _agents.Add(Theater);
        }

        public void SimulateModel()
        {
            Time = 0;
            var tMin = double.MaxValue;
            Agent activeAgent = null;

            do
            {
                foreach (var agent in _agents)
                {
                    var agentTime = agent.GetNextEventTime();
                    if (agentTime < tMin)
                    {
                        tMin = agentTime;
                        activeAgent = agent;
                    }
                }

                Time = tMin;
                activeAgent?.ProcessEvent();
            } while (!IsStopCondition(Time, activeAgent));

        }

        private bool IsStopCondition(double t, Agent agent)
        {
            return t >= _totalTime || agent == null;
        }
    }
}