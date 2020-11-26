using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveAnimation : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.Play("Stop");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameManager.Instance.Score += 1;
        //ScoreText.text = "Score: " + GameManager.Instance.Score;
        if (collision.CompareTag("Player"))
        {

            m_Animator.Play("AhornAnimation");
        }
        else
        {
            m_Animator.Play("Stop");
        }
    }

}
