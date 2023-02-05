using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damegePlayer : MonoBehaviour
{
    public int damegeToPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<player>())
        {
            //Destroy(collision.gameObject);
            other.gameObject.GetComponent<player>().life -= damegeToPlayer;
            Debug.Log(other.gameObject.GetComponent<player>().life);
        }
    }


}
