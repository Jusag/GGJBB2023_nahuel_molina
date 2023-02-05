using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackMode : MonoBehaviour
{
    public List<enemy> enemiesList;
    public GameObject shooterTurret;
    public GameObject bullet;
    public AudioClip bulletSound;
    private AudioSource audioSource;

    public GameObject tarjet;

    private float timer = 0.0f;
    public float delayShoot = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        enemiesList = new List<enemy>();
        audioSource = GetComponent<AudioSource>();
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
                timer += Time.deltaTime;

                if (timer > delayShoot)
                {
                    Instantiate(bullet, shooterTurret.transform.position, shooterTurret.transform.rotation);
                    audioSource.PlayOneShot(bulletSound);
                    timer = 0.0f;
                }
                
            }
        }
    }
    
}
