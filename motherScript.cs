using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherScript : MonoBehaviour
{
    public int motherLife = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (motherLife < 0)
            {
                motherLife = 0;
            }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<enemy>())
        {
            Destroy(collision.gameObject);
            motherLife -= 50;
            Debug.Log(motherLife);
            
            
        }
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<enemy>())
        {
            Destroy(other.gameObject);
            motherLife -= 50;
            Debug.Log(motherLife);
        }
    }
    */

}
