using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
    public float baseSpeed;
    private float speed;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("left shift"))
        {
            speed = 1.75f * baseSpeed;
        }
        else
        {
            speed = baseSpeed;
        }
        if (Input.GetKey("c") == false)
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);

            }
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);

            }
            if (Input.GetKey("s"))
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);

            }
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);

            }
            transform.Rotate(0, Input.GetAxis("Mouse X") * 5, 0);
        }

    }
}
