using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        StageData sd = Resources.Load<StageData>("StageData");
        for(int i = 0; i < 6; ++i)
        {
            for(int j = 0; j < 6; ++j)
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
