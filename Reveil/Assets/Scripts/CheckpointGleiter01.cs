using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointGleiter01 : MonoBehaviour
{
    public bool gleiterAnimation;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gleiterAnimation = true;
        }
    }
}
