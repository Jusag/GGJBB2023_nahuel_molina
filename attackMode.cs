using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackMode : MonoBehaviour
{
    public List<enemy> enemiesList;
    public GameObject shooterTurret;
    public GameObject bullet;

    public GameObject tarjet;
    // Start is called before the first frame update
    void Start()
    {
        enemiesList = new List<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        tarjet = toCloseEnemie();

        shoot();
    }

    GameObject toCloseEnemie()
    {
        GameObject aux = null;
        if (enemiesList.Count > 0)
        {
            float minDistance = 900;
            foreach (enemy element in enemiesList)
            {
                if (minDistance > (Vector3.Distance(element.gameObject.transform.position, transform.position)))
                {
                    minDistance = (Vector3.Distance(element.gameObject.transform.position, transform.position));
                    aux = element.gameObject;
                }
            }
        }
        return aux;
    }

    void shoot()
    {
        if (tarjet != null)
        {
            
            if( Vector3.Distance(tarjet.transform.position, transform.position) < 30 && GetComponent<player>().isUnderground == false )
            {

                shooterTurret.transform.LookAt(tarjet.transform);
                
                Instantiate(bullet, shooterTurret.transform.position, shooterTurret.transform.rotation);
            }
        }
    }

}
