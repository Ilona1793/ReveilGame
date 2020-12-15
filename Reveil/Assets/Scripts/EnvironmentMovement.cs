using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMovement : MonoBehaviour

    
{
    private Animator anim;
    
    private void Start()
    {
    anim = GetComponent<Animator>();
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("move");
            anim.SetTrigger("CloudTrigger");
            anim.SetTrigger("LampionTrigger");
            anim.SetTrigger("SchilfTrigger");
        }
    }
}
