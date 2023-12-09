using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace NeuralNetworkLesson {
    class NeuralNetwork {
        // first neurons
        private List<InputNeuron> inputNeurons;


        //last neurons
        private List<WorkingNeuron> outputNeurons;


        //inner neurons
        private List<List<WorkingNeuron>> hiddenNeurons;

        private System.Random random;


        public NeuralNetwork(int numberofInputs, int[] neuronsPerLayer, int numberOfOutputs) {

            inputNeurons = new List<InputNeuron>();
            hiddenNeurons = new List<List<WorkingNeuron>>();
            outputNeurons = new List<WorkingNeuron>();
            random = new System.Random();

            CreateInputLayer(numberofInputs);
            CreateHiddenLayer(neuronsPerLayer);
            CreateOutputLayer(numberOfOutputs);
            CreateFullMesh();

        }



        /// <summary>
        /// Adds an neuron objekt to the list InputNeurons to edit them individualy 
        /// </summary>
        /// <param name="numberOfInputs"></param>
        private void CreateInputLayer(int numberOfInputs) {
            for (int i = 0; i < numberOfInputs; i++) {
                InputNeuron input = new InputNeuron();
                inputNeurons.Add(input);
            }

        }


        private void CreateHiddenLayer(int[] neuronsPerLayer) {
            foreach (int layer in neuronsPerLayer) {
                List<WorkingNeuron> L = new List<WorkingNeuron>();
                for (int i = 0; i < layer; i++) {
                    WorkingNeuron hidden = new WorkingNeuron();
                    L.Add(hidden);
                }
                hiddenNeurons.Add(L);
            }
        }

        private void CreateOutputLayer(int numberOfOutputs) {
            for (int i = 0; i < numberOfOutputs; i++) {
                WorkingNeuron output = new WorkingNeuron();
                outputNeurons.Add(output);
            }

        }



        public void deltaLearning(float[] shoulds, float epsilon ){

            if(shoulds.Length != outputNeurons.Count()) {
                throw new Exception("u are gay weil du falsche anzahl von inputs hast du eumel ");
            }
            if(hiddenNeurons.Count() != 0) {
                throw new Exception("ahhhh ne du kann ich n ciht weil hidden layer (bin deltsa junge)");
            }

            for(int i = 0 ; i < shoulds.Length; i++) {
                float smallDelta = shoulds[i] - outputNeurons[i].GetValue();
                //print("smallDelta: " + smallDelta);
                outputNeurons[i].deltaLearning(epsilon, smallDelta);
            }
        }


        /// <summary>
        /// Das Objekt w besitzt eine liste connections zu dieser liste wird für jedes 
        /// inputNeuron in der Liste input neurons eine Connetion in die liste connections hinzugefügt 
        /// w.AddConnection(new Connection(i,weight)) ~ WorkingNeuron.addConnection(add Connection(i,weight) )in die liste Connections
        /// </summary>
        private void CreateFullMesh() {

            // There is no Hidden Layer 
            if (hiddenNeurons.Count == 0) {
                foreach (WorkingNeuron w in outputNeurons) {
                    foreach (InputNeuron i in inputNeurons) {
                        w.AddConnection(new Connection(i, (float)(random.NextDouble() - 0.5)));
                    }
                }
            }
            //There is a minimum of one hidden layer
            else {
                //Input to hidden layer
                foreach (WorkingNeuron w in hiddenNeurons[0]) {
                    foreach (InputNeuron i in inputNeurons) {
                        w.AddConnection(new Connection(i, (float)(random.NextDouble() - 0.5)));
                    }
                }
                //Hidden layer to other Hidden layers
                for (int layer = 1; layer < hiddenNeurons.Count; layer++) {
                    foreach (WorkingNeuron wLayer in hiddenNeurons[layer]) {
                        foreach (WorkingNeuron wPreviousLayer in hiddenNeurons[layer - 1]) {
                            wLayer.AddConnection(new Connection(wPreviousLayer, (float)(random.NextDouble() - 0.5)));
                        }
                    }
                }

                //Hidden to Output Connection
                foreach (WorkingNeuron w in outputNeurons) {
                    foreach (WorkingNeuron h in hiddenNeurons[hiddenNeurons.Count - 1]) {
                        w.AddConnection(new Connection(h, (float)(random.NextDouble() - 0.5)));
                    }
                }
            }
        }

        public void SetInputs(float[] inputs) {
            if (inputs.Length != inputNeurons.Count) {
                throw new Exception($"Error!!! You provided {inputs.Length} value, but the network has {inputNeurons.Count} input Neurons");
            }
                for (int i = 0; i < inputNeurons.Count; i++) {
                    inputNeurons[i].SetValue(inputs[i]);

                
                }
            
        }

        public float[] GetOutputs() {
            float[] outputs = new float[outputNeurons.Count];
            for (int i = 0; i < outputNeurons.Count; i++) {
                outputs[i] = outputNeurons[i].GetValue();
            } 
            return outputs;

        }

    }
}
