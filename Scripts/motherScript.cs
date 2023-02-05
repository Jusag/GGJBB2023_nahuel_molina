using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motherScript : MonoBehaviour
{
    public int motherLife = 1000;
    private int lifeAux;
    private AudioSource audioSource;
    public AudioClip lifeLost;

    // Start is called before the first frame update
    void Start()
    {
        lifeAux = motherLife;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (motherLife < 0)
            {
                motherLife = 0;
            }

        if (lifeAux != motherLife)
        {
            lifeAux = motherLife;
            audioSource.PlayOneShot(lifeLost);
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
