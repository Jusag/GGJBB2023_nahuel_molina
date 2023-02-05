using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterArm : MonoBehaviour
{
    public Transform targetAcquired;
    public float damping = 2.0f;
    public float distanceOfAttack;
    public GameObject projectile;
    private float timer = 0.0f;
    public float delayShoot = 1.0f;
    public int magazineSize = 1;
    private int magCount = 0;
    public int timeToReload;
    private bool isReloading = false;
    // Start is called before the first frame update
    void Start()
    {
        targetAcquired = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Turret track the actual target
        float distanceToTarget = Vector3.Distance(targetAcquired.position, transform.position);
        float damping = 2.0f;
        Vector3 lookPos = targetAcquired.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);

        if (distanceOfAttack >= distanceToTarget)
        {
            timer += Time.deltaTime;
            if (timer > delayShoot && magazineSize > magCount && isReloading == false)
            {
                Instantiate(projectile, transform.position + transform.forward*10, transform.rotation);
                timer = 0.0f;
                magCount++;


            }
            else if (magazineSize <= magCount)
            {
                isReloading = true;
                StartCoroutine(FireReload());
            }

        }
    }

    IEnumerator FireReload()
    {
        yield return new WaitForSeconds(timeToReload);
        isReloading = false;
        magCount = 0;
    }
}
