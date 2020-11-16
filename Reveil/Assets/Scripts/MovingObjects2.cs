using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects2 : MonoBehaviour
{
    public float Speed = 1.5f;
    private Rigidbody2D rBody;


    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(-Speed, 0f);
    }

    private void Update()
    {
        if (GameManager.Instance.IsGameOver && rBody.velocity != Vector2.zero)
        {
            rBody.velocity = Vector2.zero;
        }
    }
}
