using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour
{

    [SerializeField]
    Transform transTowards;

    [SerializeField]
    float fSpeed;

    Rigidbody2D rigid;

    private bool MoveStardust = false;

    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
        if (transTowards == null)
        {
            transTowards = FindObjectOfType<Sphere>().transform;
        }
    }


    void Update()
    {
       // if (MoveStardust == true)
       // {
            rigid.velocity += ((Vector2)(transTowards.position - transform.position)).normalized * fSpeed * Time.deltaTime;
       // }
    }

    /*private void OnColliderEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoveStardust = true;
        }
    }*/
}