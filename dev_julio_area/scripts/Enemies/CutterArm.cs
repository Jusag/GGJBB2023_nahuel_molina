using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterArm : MonoBehaviour
{
    public Transform targetAcquired;

    // Start is called before the first frame update
    void Start()
    {
        targetAcquired = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Turret track the actual target
        float damping = 2.0f;
        Vector3 lookPos = targetAcquired.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }
}
