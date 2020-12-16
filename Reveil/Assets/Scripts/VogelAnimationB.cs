using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VogelAnimationB : MonoBehaviour
{
    Animator m_Animator;
    public CheckpointVogelB Checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        if (Checkpoint.vogelAnimation == true)
        {
            GetComponent<Animator>().enabled = true;
            m_Animator.Play("VB");
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            Checkpoint.vogelAnimation = false;
        }

    }

}
