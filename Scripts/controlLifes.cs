using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLifes : MonoBehaviour
{
    public motherScript motherlife;
    public player playerLife;
    public GameObject pantalla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife.life <= 0 || motherlife.motherLife <=0)
        {
            pantalla.SetActive(true);
        }
    }
}
