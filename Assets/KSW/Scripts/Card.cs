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
        frontimage.sprite = Resources.Load<Sprite>($"��ī��{idx}");
    }

    public void OpenCard()
    {
        //if (GameManager.Instance.secondCard != null) return;

        //audioSource.PlayOneShot(clip);
        animator.SetBool("isOpen", true);

        #region ī�� ��Ī Ȯ�� ����
        //firstCard�� ����ٸ�,
        if (GameManager.Instance.firstCard == null)
        {
            //firstCard�� �������� �Ѱ��ش�.
            GameManager.Instance.firstCard = this;
            Debug.Log(idx);
        }
        else
        {
            // secondCard�� �� ������ �Ѱ��ش�
            GameManager.Instance.secondCard = this;
            // Matched �Լ��� ȣ���Ѵ�.
            GameManager.Instance.Matched();
            Debug.Log(idx);
        }
        // secondCard�� �� ������ �Ѱ��ش�
        // Matched �Լ��� ȣ���Ѵ�.
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
