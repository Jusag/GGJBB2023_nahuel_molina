using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int life = 100;
    private int lifeAux;
    public bool isUnderground = false;

    // Start is called before the first frame update
    void Start()
    {
        lifeAux = life;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(life);
        if (isUnderground)
        {
            offMeshes();
        }
        else
        {
            onMeshes();
        }

        if (life <= 0)
        {
            gameObject.GetComponent<controls>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            isUnderground = true;
            life = 0;
        }

        if (lifeAux !=  life) 
        {
            lifeAux = life;
        }
    }
    private void onMeshes()
    {
        //GameObject.FindGameObjectWithTag("floor").GetComponent<MeshRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("floor").GetComponent<Terrain>().enabled = true;
    }
    private void offMeshes()
    {
        //GameObject.FindGameObjectWithTag("floor").GetComponent<MeshRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("floor").GetComponent<Terrain>().enabled = false;
    }

}
