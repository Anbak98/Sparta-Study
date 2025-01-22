using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button normalButton;
    [SerializeField] Button hardButton;
    
    private void Awake()
    {
        normalButton.onClick.AddListener(() =>
        {
            StageData sd = Resources.Load<StageData>("StageData");
            sd.width = 6;
            sd.height = 6;
            SceneManager.LoadScene("SampleScene");
        });

        hardButton.onClick.AddListener(() =>
        {
            StageData sd = Resources.Load<StageData>("StageData");
            sd.width = 10;
            sd.height = 10;
            
            SceneManager.LoadScene("SampleScene");
        });
    }
}
