using UnityEngine;

public class Nightmare : MonoBehaviour
{
    public float acceleration = 1.2f;
    public float maxSpeed = 6f;
    public float curSpeed = 0.1f;

 
    private void Update () {
        

        transform.Translate(Vector3.right * curSpeed * Time.deltaTime);
        
 
        curSpeed += acceleration * Time.deltaTime;
        //Debug.Log("Speed: " + curSpeed);
 
        if (curSpeed > maxSpeed)
            curSpeed = maxSpeed;
    }
}
