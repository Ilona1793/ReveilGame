
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //wiederholung
        //float temp = (cam.transform.position.x *(1-parallaxEffect));

        //wichtiger code
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        //wiederholung
        //if(temp > startpos + length) startpos += length;
        //else if (temp < startpos - length) startpos -= length;
    }
}
