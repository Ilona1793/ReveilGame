using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Level 2
        if (Time.timeSinceLevelLoad >= 30)
        {
            m_Animator.Play("AhornAnimation");
        } else
        {
            m_Animator.Play("Stop");
        }


        //Level 3
        if (Time.timeSinceLevelLoad >= 5)
        {
            m_Animator.Play("Vogel");
        }
        else
        {
            m_Animator.Play("StopVogel");
        }
    }
}
