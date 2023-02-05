using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public int spawnIntTime;
    private bool control = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!control)
        {
            StartCoroutine(spawnTime());
        }
    }
    private IEnumerator spawnTime()
    {
        control = true;
        int value = Random.Range(0,3);

        if (value == 0) { Instantiate(enemy1, transform.position, Quaternion.identity); }
        else if (value == 1) { Instantiate(enemy2, transform.position, Quaternion.identity); }
        else if (value == 2) { Instantiate(enemy3, transform.position, Quaternion.identity); }

        yield return new WaitForSeconds(spawnIntTime);
        control = false;
    }
}
