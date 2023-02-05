using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLifePlayer : MonoBehaviour
{
    public GameObject playerObj;

    private bool controlArea = true;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(controlArea == false)
        {
            controlArea = true;
            StartCoroutine(lifeLost());
        }
    }

    private IEnumerator lifeLost()
    {
        //if (controlArea == false)
        {
            playerObj.GetComponent<player>().life -= 1;
            Debug.Log(playerObj.GetComponent<player>().life);
            yield return new WaitForSeconds(1);
            controlArea = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "player")
        {
            controlArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            controlArea = false;
        }
    }

}
