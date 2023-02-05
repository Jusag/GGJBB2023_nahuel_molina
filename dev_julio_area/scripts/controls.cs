using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    private bool lerpControl = false;
    private player auxLocalPlayer;
    public GameObject paticles;

    [SerializeField]
    private int limitMove;


    // Start is called before the first frame update
    void Start()
    {
        auxLocalPlayer = (player)this.gameObject.GetComponent(typeof(player));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * new Vector3(0, 0, 1) * Time.deltaTime * speed);

            if (transform.position.z < -38)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    -38
                );
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * new Vector3(1, 0, 0) * Time.deltaTime * speed);
            if (transform.position.x < limitMove)
            {
                transform.position = new Vector3(
                    limitMove,
                    transform.position.y,
                    transform.position.z
                );
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lerpControl = !lerpControl;
            Instantiate(
                paticles,
                new Vector3(transform.position.x,0.1f,transform.position.z),
                Quaternion.identity);
        }
        if (lerpControl == false)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 1, transform.position.z), speed / 3 * Time.deltaTime);
            if (auxLocalPlayer != null)
            {
                auxLocalPlayer.isUnderground = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, -5, transform.position.z), speed / 3 * Time.deltaTime);
            if (auxLocalPlayer != null)
            {
                auxLocalPlayer.isUnderground = true;
            }
        }
    }

    private void moveLerp(int value)
    {
        while (transform.position.y != value)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, value, transform.position.z), speed / 3 * Time.deltaTime);
        }
        lerpControl = false;
    }
}



