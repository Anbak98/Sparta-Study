using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtn : MonoBehaviour
{
    public void StartGame()
    {
        //�� �ҷ�����
        SceneManager.LoadScene(/*�ҷ��� �� ���� �̸�*/"BoardScene");
    }
    public void MenuReturn()
    {
        //�� �ҷ�����
        SceneManager.LoadScene(/*�ҷ��� �� ���� �̸�*/"MainMenuScene");
    }
}
