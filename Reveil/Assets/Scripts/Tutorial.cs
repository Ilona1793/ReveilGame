using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorial;
    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(true);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TextTime());
    }

    IEnumerator TextTime()
    {
        yield return new WaitForSeconds(5);
        tutorial.SetActive(false);

    }


}
