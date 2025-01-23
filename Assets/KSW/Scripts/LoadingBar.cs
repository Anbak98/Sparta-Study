using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public RectTransform front;
    float time = 0;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    private void Update()
    {
        time += Time.deltaTime;
        front.localScale = new Vector3(time / 3.0f, 1.0f, 1.0f);
        if (time >= 3.0f)
        {
            front.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            Invoke("StartGame", 0.5f);
        }
    }
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
