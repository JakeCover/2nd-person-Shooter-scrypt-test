using UnityEngine;
using System.Collections;

public class enemyLook : MonoBehaviour {
    private float rotationY = 0f;
    private float sensitivityY = 2f;
    private float parentX;
    private float parentY;
    private float parentZ;


    // Use this for initialization
    void Start () {
        parentX = gameObject.transform.parent.rotation.x;
        parentY = gameObject.transform.parent.rotation.y;
        parentZ = gameObject.transform.parent.rotation.z;
        transform.eulerAngles = new Vector3(parentX, parentY, parentZ);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("c"))
        {
            parentX = gameObject.transform.parent.rotation.x;
            parentY = gameObject.transform.parent.rotation.y;
            parentZ = gameObject.transform.parent.rotation.z;
            rotationY += Input.GetAxis("Mouse X") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, parentY - 15, parentY + 15);

            transform.localEulerAngles = new Vector3(parentX, rotationY, parentZ);
            
        }
    }
}
