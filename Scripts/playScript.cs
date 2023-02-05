using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lifesUI;
    public GameObject enemiesUI;
    public GameObject StartUI;

    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playscript()
    {
        //SceneManager.LoadScene("Enemigos");
        
        StartUI.SetActive(false);

        lifesUI.SetActive(true);
        enemiesUI.SetActive(true);
        spawner1.SetActive(true);
        spawner2.SetActive(true);
        spawner3.SetActive(true);

        GameObject auxGame = GameObject.FindGameObjectWithTag("GameController");
        auxGame.GetComponent<MusicControls>().gameCMenu.Stop();
        auxGame.GetComponent<MusicControls>().gameCGameTop.Play();
        auxGame.GetComponent<MusicControls>().gameCGameBop.Play();
        auxGame.GetComponent<MusicControls>().gameCGameBop.volume = 0;
        
    }
    
}
