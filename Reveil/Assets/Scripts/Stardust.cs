using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stardust : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer sr;
    private CircleCollider2D bc;
    // Start is called before the first frame update
    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<CircleCollider2D>();
    }

    private void OnColliderEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        particle.Play();

        sr.enabled = false;
        bc.enabled = false;

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(gameObject);
    }
}
