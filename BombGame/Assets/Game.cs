using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {

    private int min;
    private int max;
    private int size;

    public int[] randomOrder;


    public Game (int min, int max, int size)
    {
        this.min = min;
        this.max = max;
        this.size = size;
    }

    public int[] CreateRandomOrder ()
    {
        randomOrder = new int[size];
        for (int i = 0; i < randomOrder.Length; i++)
        {
            randomOrder[i] = GetRandomRange();
        }
        return randomOrder;
    }

    public int GetRandomRange()
    {
        return Random.Range(min, max);
    }
}
