using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    class CNet:ACNet
    {
        public CNet() : base(1)
        {
            for (int i = 0; i < 9; i++)
            {
                AddInputNeuron();
            }
            for (int i = 0; i < 6; i++)
            {
                AddHideNeuron(0);
            }
            for (int i = 0; i < 6; i++)
            {
                AddOutputNeuron();
            }
            AddConnections();
        }
        private void AddConnections()
        {
            int[][] aHideConnections = new int[1][];
            int[] aOutputConnections = { 0, 0, 0, 0, 0, 0 };

            aHideConnections[0] = new int[6] { 1, 0, 0, 1, 0, 0 };
            InputConnections(0, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 1, 0, 0, 0, 1, 0 };
            InputConnections(1, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 1, 0, 0, 0, 0, 1 };
            InputConnections(2, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 0, 1, 0, 1, 0, 0 };
            InputConnections(3, aHideConnections, aOutputConnections);
            
            aHideConnections[0] = new int[6] { 0, 1, 0, 0, 1, 0 };
            InputConnections(4, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 0, 1, 0, 0, 0, 1 };
            InputConnections(5, aHideConnections, aOutputConnections);
            
            aHideConnections[0] = new int[6] { 0, 0, 1, 1, 0, 0 };
            InputConnections(6, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 0, 0, 1, 0, 1, 0 };
            InputConnections(7, aHideConnections, aOutputConnections);

            aHideConnections[0] = new int[6] { 0, 0, 1, 0, 0, 1 };
            InputConnections(8, aHideConnections, aOutputConnections);
            /****************************************************************/
            aHideConnections[0] = new int[6] { 0, 0, 0, 0, 0, 0 };
            
            aOutputConnections = new int[6] { 0, 1, 1, 1, 1, 1 };
            HideConnections(0, 0, aHideConnections, aOutputConnections);

            aOutputConnections = new int[6] { 1, 0, 0, 0, 0, 0 };
            HideConnections(0, 1, aHideConnections, aOutputConnections);

            aOutputConnections = new int[6] { 0, 0, 0, 0, 1, 1 };
            HideConnections(0, 2, aHideConnections, aOutputConnections);

            aOutputConnections = new int[6] { 1, 0, 1, 1, 1, 1 };
            HideConnections(0, 3, aHideConnections, aOutputConnections);

            aOutputConnections = new int[6] { 0, 1, 0, 0, 0, 0 };
            HideConnections(0, 4, aHideConnections, aOutputConnections);

            aOutputConnections = new int[6] { 1, 0, 0, 1, 0, 1 };
            HideConnections(0, 5, aHideConnections, aOutputConnections);
        }
        public void RandomizeWeights()
        {
            foreach(CNeuron rNeuron in m_aOutput)
            {
                rNeuron.RandomizeWeights();
            }
        }
       
    }
}
