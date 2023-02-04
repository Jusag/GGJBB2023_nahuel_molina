using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private int life = 0;
    public bool isUnderground = false;

    // Start is called before the first frame update
    void Start()
    {
        life = 100;
    }
    

    // Update is called once per frame
    void Update()
    {
        if(isUnderground)
        {
            offMeshes();
        }
        else
        {
            onMeshes();
        }
    }
    private void onMeshes()
    {
        GameObject.FindGameObjectWithTag("floor").GetComponent<MeshRenderer>().enabled = true;
    }
    private void offMeshes()
    {
        GameObject.FindGameObjectWithTag("floor").GetComponent<MeshRenderer>().enabled = false;
    }

}
