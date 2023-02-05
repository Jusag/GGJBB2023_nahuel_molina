using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControls : MonoBehaviour
{
    public AudioSource gameCMenu = new AudioSource();
    public AudioSource gameCGameTop = new AudioSource();
    public AudioSource gameCGameBop = new AudioSource();

    // Start is called before the first frame update
    void Start()
    {
        gameCMenu.Play();
        //gameC.PlayOneShot(gameMusicTop);
        //gameC.PlayOneShot(gameMusicUnder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void isunder()
    {
        gameCGameTop.volume = 0f;
        gameCGameBop.volume = 1f;
    }
    public void istop()
    {
        gameCGameTop.volume = 1f;
        gameCGameBop.volume = 0f;
    }
}

