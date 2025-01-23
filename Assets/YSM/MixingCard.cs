//System
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//UnityEngine
using UnityEngine;

public class MixingCard 
{
    GameObject[,] cards;
    int width;
    int height;

    public MixingCard(GameObject[,] objs)
    {
        cards = objs;
        width = objs.GetLength(0);
        height = objs.GetLength(1);
    }

    public void AssignIdxRandomly()
    {
        int[] numbers = Enumerable.Range(1, width*height).SelectMany(n => Enumerable.Repeat(n, 2)).ToArray();
        
        var random = new System.Random();
        int[] shuffledNumbers = numbers.OrderBy(_ => random.Next()).ToArray();

        if(cards == null)
        {
            Debug.Log("NULL");
        }

        for(int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                cards[i, j].GetComponent<Card>().Setting(shuffledNumbers[i*width+height]);
            }
        }
    }
}
