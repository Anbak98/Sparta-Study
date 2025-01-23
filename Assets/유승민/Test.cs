using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        var sd = Resources.Load<StageData>("StageData");

        for(int i = 0; i < sd.width; ++i)
        {
            for(int j = 0; j < sd.height; ++j)
            {
                Instantiate(obj, new Vector3(i, j), Quaternion.identity);
            }
        }

        Debug.Log($"TEST {sd.width}, {sd.height}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
