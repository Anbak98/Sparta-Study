using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Card firstCard { get; set; }
    public Card secondCard { get; set; }
    public Text timeTxt;

    public GameObject SuccessEndPanel;
    public GameObject FailEndPanel;

    AudioSource audioSource;
    public AudioClip clip;

    int cardCount = 0;
    float time = 0.0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        FailEndPanel.SetActive(false);
        SuccessEndPanel.SetActive(false);
        Application.targetFrameRate = 60;
        int w = PlayerPrefs.GetInt("Width");
        int h = PlayerPrefs.GetInt("Height");
        cardCount = w * h;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        time = PlayerPrefs.GetFloat("Timer");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (cardCount!= 0 && time <= 0.0f)
        {
            Time.timeScale = 0.0f;
            timeTxt.text = "0.0";
            FailEndPanel.SetActive(true);
        }

        timeTxt.text = time.ToString("N2");
    }
    public void Matched()
    {
        if (firstCard.idx == secondCard.idx)
        {

            //ÆÄ±«ÇØ¶ó
            audioSource.PlayOneShot(clip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if (cardCount == 0)
            {
                Time.timeScale = 0.0f;
                SuccessEndPanel.SetActive(true);
                timeTxt.text = time.ToString("N2");
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
        }
        firstCard = null;
        secondCard = null;
    }
}
