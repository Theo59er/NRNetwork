using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLesson
{
    class InputNeuron : Neuron
    {
        private float value = 0f;

        public override float GetValue()
        {
            return value;
        }


        /// <summary>
        /// Should be 
        /// filled with the inputs for the neural network
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(float value)
        {
            this.value = value;
        }
    }
}
