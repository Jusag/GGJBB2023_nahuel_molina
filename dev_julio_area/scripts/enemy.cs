using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int unitHealth;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("player").GetComponent<attackMode>().enemiesList.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (unitHealth <= 0) 
        {
            GameObject.FindGameObjectWithTag("player").GetComponent<attackMode>().enemiesList.Remove(this);
            Destroy(this.gameObject);
        }
    }
}
