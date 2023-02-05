using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playableZone : MonoBehaviour
{
    public GameObject player;
    public GameObject rootZone;
    public GameObject roots;
    private AudioSource audioSource;
    public AudioClip pickUp;



    // Start is called before the first frame update
    void Start()
    {
        roots = GameObject.FindGameObjectWithTag("Roots");
        player = GameObject.FindGameObjectWithTag("player");
        rootZone = GameObject.FindGameObjectWithTag("gamezone");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            player.GetComponent<player>().life += 5;
            if(player.GetComponent<player>().life > 100)
            {
                player.GetComponent<player>().life = 100;
            }
            
            /*
            Vector3 auxSpawnVectorSize = rootZone.GetComponent<BoxCollider>().size;
            auxSpawnVectorSize.x += 0.1f;
            auxSpawnVectorSize.y += 0.1f;
            auxSpawnVectorSize.z += 0.1f;
            rootZone.GetComponent<BoxCollider>().size = auxSpawnVectorSize;
            rootZone.GetComponent<CapsuleCollider>().radius += 0.1f;
            */

            Vector3 auxSpawnVectorSize = rootZone.GetComponent<Transform>().localScale;
            auxSpawnVectorSize.x += 5;
            auxSpawnVectorSize.y +=5;
            //auxSpawnVectorSize.z += 5;
            rootZone.GetComponent<Transform>().localScale = auxSpawnVectorSize;
            roots.GetComponent<Transform>().localScale = auxSpawnVectorSize;

            StartCoroutine(TimeDissapear());

        }
    }

    IEnumerator TimeDissapear() 
    {
        audioSource.PlayOneShot(pickUp);
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }

    
}
