using System;
using Backprop;

public class BattleRoyaleManager
{
    NeuralNet[] neuralNets;
    int[] SuccessCase;
    int[] trainCount;
    int[] HnodeCount;
    public BattleRoyaleManager()
	{
        neuralNets = new NeuralNet[100];
        for (int Ncount = 1; Ncount <= 100; Ncount++)
        {
            neuralNets[Ncount] = new NeuralNet(4, Ncount, 1);
        }

    }
}
