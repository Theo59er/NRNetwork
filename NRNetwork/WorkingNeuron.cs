using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLesson
{
    class WorkingNeuron : Neuron
    {
        List<Connection> connections = new List<Connection>();

        /// <summary>
        /// Returns the sum of all preceding neurons from the preceding layer ( using tanh to get value between -1/+1)
        /// </summary>
        /// <returns> value between -1 and +1 </returns>
        public override float GetValue() {
            float sum = 0f;

            foreach(Connection c in connections) {
                sum += c.GetValue();
            }

            return (float)Math.Tanh(sum);  
        }




        /// <summary>
        /// Adds the connection to this neuron
        /// </summary>
        /// <param name="c">the connection to be added </param>
        public void AddConnection(Connection c)
        {
            connections.Add(c);
        }


        /// <summary>
        /// Returns all the connectet neurons with there weight from the preceding layer 
        /// </summary>
        /// <returns>A List of connections</returns>
        public List<Connection> GetConnections() { 
            return connections; 
        }

        public void deltaLearning(float epsilon, float smallDelta) {
            for (int i = 0; i < connections.Count(); i++) {
                float bigDelta = epsilon * smallDelta * connections[i].GetValue();

                connections[i].AddWeight(bigDelta);
            }
        }

    }
    }

