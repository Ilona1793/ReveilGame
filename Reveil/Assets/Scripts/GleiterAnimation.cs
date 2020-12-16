using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GleiterAnimation : MonoBehaviour
{
    Animator m_Animator;
    public CheckpointGleiterA gleiterCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        GetComponent<Animator>().enabled = false;

        //leavesCheckpoint = FindObjectOfType<Checkpoint>();
    }

    void Update()
    {
        if (gleiterCheckpoint.gleiterAnimation == true)
        {
            GetComponent<Animator>().enabled = true;
            m_Animator.Play("GL");
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            gleiterCheckpoint.gleiterAnimation = false;
        }
    }

}
