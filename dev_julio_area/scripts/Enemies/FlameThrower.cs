using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlameThrower : MonoBehaviour
{
    private NavMeshAgent enemytarget;
    [SerializeField]
    private player checkUnderground;
    [SerializeField]
    private Transform playerLocation;
    [SerializeField]
    private Transform baseLocation;
    [SerializeField]
    private FlameThrowerTurret turretTarget;

    // Start is called before the first frame update
    void Start()
    {
        enemytarget = GetComponent<NavMeshAgent>();
        baseLocation = GameObject.FindGameObjectWithTag("mother").transform;
        checkUnderground = GameObject.FindGameObjectWithTag("player").GetComponent<player>();
        playerLocation = GameObject.FindGameObjectWithTag("player").transform;

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
            turretTarget.targetAcquired = baseLocation;
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
                turretTarget.targetAcquired = playerLocation;
            }
            else
            {
                //chase base
                enemytarget.SetDestination(baseLocation.position);
                turretTarget.targetAcquired = baseLocation;
            }
        }
    }
}
