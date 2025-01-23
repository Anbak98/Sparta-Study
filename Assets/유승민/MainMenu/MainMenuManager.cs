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
            PlayerPrefs.SetInt("Width", 6);
            PlayerPrefs.SetInt("Height", 6);
            SceneManager.LoadScene("SampleScene");
        });

        hardButton.onClick.AddListener(() =>
        {
            PlayerPrefs.SetInt("Width", 10);
            PlayerPrefs.SetInt("Height", 10);
            SceneManager.LoadScene("SampleScene");
        });
    }
}
