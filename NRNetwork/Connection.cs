using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLesson
{
    class Connection{
        private Neuron neuron;
        private float weight;

        public Connection(Neuron neuron, float weight)
        {
            this.neuron = neuron;
            this.weight = weight;
        }

        public float GetValue()
        {
            return neuron.GetValue() * weight;
        }
        public float GetWeight() { 
            return weight; 
        }

        // Für evulotionäres Training

        public void AddWeight(float weight)
        {
            this.weight += weight;
        }

    }

   

    
}
