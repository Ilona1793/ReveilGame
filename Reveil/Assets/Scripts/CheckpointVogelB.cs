using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointVogelB : MonoBehaviour
{
    public bool vogelAnimation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vogelAnimation = true;
        }
    }
}
