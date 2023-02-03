using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    private bool delayCheck = false;
    // Start is called before the first frame update
    void Start()
    {

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
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-1 * new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate()
            if (transform.position.y > 0)
            {
                transform.position = Vector3.Lerp(
                    transform.position,
                    new Vector3(transform.position.x, -5, transform.position.z),
                    1);
                    //terminar de verficar el desplazamiento smoth
            }
            else
            {
                transform.position = Vector3.Lerp(
                    transform.position,
                    new Vector3(transform.position.x, 1, transform.position.z),
                    1);
            }
        }


    }
}
