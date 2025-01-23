using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        GetStageData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetStageData()
    {
        int width = PlayerPrefs.GetInt("Width");
        int height = PlayerPrefs.GetInt("Height");

        if(width == 6 || height == 6)
        {
            for(int i = 0; i < width * height; ++i)
            {

            }
        }
        else if(width == 10 || height == 10)
        {
            for (int i = 0; i < width * height; ++i)
            {

            }
        }

        for (int i = 0; i < width; ++i)
        {
            for (int j = 0; j < height; ++j)
            {
                Instantiate(obj, new Vector3(i, j), Quaternion.identity);
            }
        }

        Debug.Log($"TEST {width}, {height}");
    }
}
