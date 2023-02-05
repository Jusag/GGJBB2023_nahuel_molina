using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getLife : MonoBehaviour
{
    GameObject motheobj;
    
    // Start is called before the first frame update
    void Start()
    {
        motheobj = GameObject.FindGameObjectWithTag("mother");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = motheobj.GetComponent<motherScript>().motherLife +"";
    }
}
