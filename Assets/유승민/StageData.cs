using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "StageData")]
public class StageData : ScriptableObject
{
    [SerializeField] public int width = 0;
    [SerializeField] public int height = 0;
    [SerializeField] public float time = 60.0f;
}
