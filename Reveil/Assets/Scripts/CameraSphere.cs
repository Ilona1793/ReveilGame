using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSphere : MonoBehaviour
{
    [SerializeField] private Sphere sphere;
    [SerializeField] private float speed = 1f;

    Vector3 targetPosition;

    // Update is called once per frame
    void Update()
    {
        targetPosition = Vector3.Lerp(transform.position, sphere.transform.position, Time.deltaTime * speed) ;
        targetPosition.z = transform.position.z;
        targetPosition.y = transform.position.y;
        transform.position = targetPosition;
    }
}
