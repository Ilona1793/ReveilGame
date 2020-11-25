using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStardustToSphere : MonoBehaviour
{
   
        public Transform target;
        public float speed;
        public bool isMoving = false;

        void Update()
        {
            if (isMoving)
            {
                transform.position = Vector3
                .MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }

        public void MoveToPlayer(Transform player)
        {
            target = player;
            isMoving = true;
        }
    

}
