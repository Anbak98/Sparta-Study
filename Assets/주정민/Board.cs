using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject bod;

    // Start is called before the first frame update
    void Start()
    {
        int width = PlayerPrefs.GetInt("Width");
        int height = PlayerPrefs.GetInt("Height");
        float interval = PlayerPrefs.GetFloat("Interval");

            for (int i = 0; i < width * height; ++i)
            {
                GameObject go = Instantiate(bod, this.transform);

            float x = (i % width) * interval;
            float y = (i / height) * interval;

                go.transform.position = new Vector2(x, y);
            }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
