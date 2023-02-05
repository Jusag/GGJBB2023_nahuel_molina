using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField]
    private float pSpeed = 60.0f;
    [SerializeField]
    public int damageToEnemy = 10;
    public int powerUpDamage = 0;
    [SerializeField]
    private float lifeTime = 10.0f;

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
        if (other.gameObject.GetComponent<enemy>())
        {
            //Destroy(collision.gameObject);
            other.gameObject.GetComponent<enemy>().unitHealth -= damageToEnemy + powerUpDamage;
        }
        Destroy(this.gameObject);
    }

    
}