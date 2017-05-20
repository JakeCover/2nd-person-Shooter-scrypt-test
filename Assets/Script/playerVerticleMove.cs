using UnityEngine;
using System.Collections;

public class playerVerticleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("c") == false)
        {
            transform.Rotate(Input.GetAxis("Mouse Y") * 2 * -1, 0, 0);
        }
    }
}
