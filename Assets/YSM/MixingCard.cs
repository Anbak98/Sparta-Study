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
        numbers = numbers.OrderBy(_ => Random.Range(0.0f, 10.0f)).ToArray();

        string log = "";
        foreach (int number in numbers)
        {
            log += number + ", ";
        }
        Debug.Log(log);

        if(cards == null)
        {
            Debug.Log("NULL");
        }

        for(int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                cards[i, j].GetComponent<Card>().Setting(numbers[i+j*height]);
            }
        }
    }
}
