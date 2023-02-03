using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bulldozer : MonoBehaviour
{
    private NavMeshAgent enemytarget;
    [SerializeField]
    private player checkUnderground;   
    [SerializeField]
    private Transform playerLocation;
    [SerializeField]
    private Transform baseLocation;

    // Start is called before the first frame update
    void Start()
    {
        enemytarget = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // What should I chase?
        GetTarget();       
    }

    void GetTarget() 
    {
        //check player is underground
        if (checkUnderground.isUnderground == true)
        {
            //If player is undeground, chase base
            enemytarget.SetDestination(baseLocation.position);

        }
        else
        {
            //If not, look for closest one
            float distAux = Vector3.Distance(playerLocation.position, transform.position);
            float distAux2 = Vector3.Distance(baseLocation.position, transform.position);

            if (distAux < distAux2)
            {
                //Chase player
                enemytarget.SetDestination(playerLocation.position);

            }
            else
            {
                //chase base
                enemytarget.SetDestination(baseLocation.position);
            }
        }
    }
}
