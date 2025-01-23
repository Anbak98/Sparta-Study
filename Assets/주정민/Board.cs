using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject bod;
    GameObject[,] cards;
    MixingCard mc;

    // Start is called before the first frame update
    void Start()
    {
        int width = PlayerPrefs.GetInt("Width");
        int height = PlayerPrefs.GetInt("Height");
        float interval = PlayerPrefs.GetFloat("Interval");

        if (width == 6)
        {
            Camera.main.transform.position = new Vector3(2.47f, 3.38f, -8.98f);
            Camera.main.orthographicSize = 5;
            cards = new GameObject[width, height];
            for (int i = 0; i < width * height; ++i)
            {

                GameObject go = Instantiate(bod, this.transform);

                float x = (i % width) * interval;
                float y = (i / height) * interval;

                go.transform.position = new Vector2(x, y);
                cards[i%width, i/height] = go;
            }
        }
        else if (width == 10)
        {
            Camera.main.transform.position = new Vector3(3.58f, 4.83f, -12.2f);
            Camera.main.orthographicSize = 7;
            cards = new GameObject[width, height];
            for (int i = 0; i < width * height; ++i)
            {

                GameObject go = Instantiate(bod, this.transform);

                float x = (i % width) * interval;
                float y = (i / height) * interval;

                go.transform.position = new Vector2(x, y);
                cards[i % width, i / height] = go;
            }
        }

        mc = new(this.cards);
        mc.AssignIdxRandomly();
    }
}
