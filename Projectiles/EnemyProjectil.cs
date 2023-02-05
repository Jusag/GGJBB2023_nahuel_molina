using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectil : MonoBehaviour
{
    [SerializeField]
    private float pSpeed = 10.0f;
    [SerializeField]
    private int damageToPlayer = 10;
    [SerializeField]
    private float lifeTime = 1.0f;
    [SerializeField]
    private float reloadTime = 1.0f;
    private bool pReloading = false;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent<Rigidbody>())
        {
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * (pSpeed);
        }        
        StartCoroutine(TimeDestroy());
    }

    IEnumerator TimeDestroy() 
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(this.gameObject);
    }

    void OnTriggerStay(Collider other)
    {
        if (pReloading == false) 
        {
            if (other.gameObject.GetComponent<player>())
            {
                //Destroy(collision.gameObject);
                other.gameObject.GetComponent<player>().life -= damageToPlayer;
                StartCoroutine(TimeReload());
            }
            if (other.gameObject.GetComponent<motherScript>())
            {
                //Destroy(collision.gameObject);
                other.gameObject.GetComponent<motherScript>().motherLife -= damageToPlayer;
                StartCoroutine(TimeReload());
            }
        }        
    }

    IEnumerator TimeReload()
    {
        pReloading = true;
        yield return new WaitForSeconds(reloadTime);
        pReloading = false;
    }

}
