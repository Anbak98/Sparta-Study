using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject bod;
    [SerializeField] Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        int width = PlayerPrefs.GetInt("Width");
        int height = PlayerPrefs.GetInt("Height");
        float interval = PlayerPrefs.GetFloat("Interval");

        if (width == 6)
        {
            camera.transform.position = new Vector3(2.47f, 3.38f, -8.98f);
            for (int i = 0; i < width * height; ++i)
            {

                GameObject go = Instantiate(bod, this.transform);

                float x = (i % width) * interval;
                float y = (i / height) * interval;

                go.transform.position = new Vector2(x, y);
            }
        }
        else if (width == 10)
        {
            camera.transform.position = new Vector3(3.58f, 4.83f, -12.2f);
            for (int i = 0; i < width * height; ++i)
            {

                GameObject go = Instantiate(bod, this.transform);

                float x = (i % width) * interval;
                float y = (i / height) * interval;

                go.transform.position = new Vector2(x, y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
