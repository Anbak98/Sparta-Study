using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;

    public Animator animator;

    public SpriteRenderer frontimage;

    AudioSource audioSource;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Setting(int number)
    {
        idx = number;
        frontimage.sprite = Resources.Load<Sprite>($"험카뒤{idx}");
    }

    public void OpenCard()
    {
        //if (GameManager.Instance.secondCard != null) return;

        //audioSource.PlayOneShot(clip);
        animator.SetBool("isOpen", true);

        #region 카드 매칭 확인 로직
        //firstCard가 비었다면,
        if (GameManager.Instance.firstCard == null)
        {
            //firstCard에 내정보를 넘겨준다.
            GameManager.Instance.firstCard = this;
            Debug.Log(idx);
        }
        else
        {
            // secondCard에 내 정보를 넘겨준다
            GameManager.Instance.secondCard = this;
            // Matched 함수를 호출한다.
            GameManager.Instance.Matched();
            Debug.Log(idx);
        }
        // secondCard에 내 정보를 넘겨준다
        // Matched 함수를 호출한다.
        #endregion
    }

    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }
    public void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 0.5f);
    }
    public void CloseCardInvoke()
    {
        animator.SetBool("isOpen", false);
    }
}
