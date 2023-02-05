using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnergy : MonoBehaviour
{
    public GameObject spwanEnergyAsset;


    private bool controltimer = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(timerSpawn());
    }
    IEnumerator timerSpawn()
    {
        if (controltimer == false)
        {
            controltimer = true;
            Vector3 auxVector = GetComponent<BoxCollider>().size;
            Instantiate(spwanEnergyAsset, 

            new Vector3(
                Random.Range(auxVector.x*20, auxVector.x+3*20),
                -5,
                Random.Range(-auxVector.z/2*20, auxVector.z/2*20)
            ),       
            Quaternion.identity);
            
            yield return new WaitForSeconds(7);
            controltimer = false;
        }
        

    }
}
