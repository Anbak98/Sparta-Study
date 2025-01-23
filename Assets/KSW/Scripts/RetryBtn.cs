using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtn : MonoBehaviour
{
    public void StartGame()
    {
        //씬 불러오기
        SceneManager.LoadScene(/*불러올 씬 파일 이름*/"BoardScene");
    }
    public void MenuReturn()
    {
        //씬 불러오기
        SceneManager.LoadScene(/*불러올 씬 파일 이름*/"MainMenuScene");
    }
}
