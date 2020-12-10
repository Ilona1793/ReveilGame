using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesAnimation : MonoBehaviour
{
    Animator m_Animator;
    public Checkpoint leavesCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        GetComponent<Animator>().enabled = false;

        //leavesCheckpoint = FindObjectOfType<Checkpoint>();
    }

    void Update()
    {
        if (leavesCheckpoint.leavesAnimation == true)
        {
            GetComponent<Animator>().enabled = true;
            m_Animator.Play("AhornAnimation");
            m_Animator.Play("AhornAnimation2");
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            leavesCheckpoint.leavesAnimation = false;
        }
    }

}
