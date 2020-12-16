using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GleiterAnimation01 : MonoBehaviour
{
    Animator m_Animator;
    public CheckpointGleiter01 gleiterCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        if (gleiterCheckpoint.gleiterAnimation == true)
        {
            GetComponent<Animator>().enabled = true;
            m_Animator.Play("GleiterAnimation01");
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            gleiterCheckpoint.gleiterAnimation = false;
        }
    }


}
