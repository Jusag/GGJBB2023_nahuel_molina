using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getlifePlayer : MonoBehaviour
{
    GameObject playerobj;
    
    // Start is called before the first frame update
    void Start()
    {
        playerobj = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = playerobj.GetComponent<player>().life +"";
    }
}
