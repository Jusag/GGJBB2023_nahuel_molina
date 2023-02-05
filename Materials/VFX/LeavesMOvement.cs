using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesMOvement : MonoBehaviour
{
    public float frequency = 2.0f;
    public float amplitude = 2.0f;

    

    void Start()
    {
        
    }

    void Update()
    {
        float x = Mathf.Cos(Time.time * frequency) * amplitude;
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
