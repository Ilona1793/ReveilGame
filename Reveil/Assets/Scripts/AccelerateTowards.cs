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
       if (MoveStardust)
       {
            //rigid.velocity += ((Vector2)(transTowards.position - transform.position)).normalized * fSpeed * Time.deltaTime;
            Vector2 dir = transTowards.position - transform.position;
            rigid.AddForce(dir.normalized * fSpeed * Time.deltaTime, ForceMode2D.Impulse);
       }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoveStardust = true;
            transTowards = collision.gameObject.transform;
        }
    }
}