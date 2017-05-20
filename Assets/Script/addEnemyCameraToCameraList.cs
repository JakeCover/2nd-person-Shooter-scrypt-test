using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class addEnemyCameraToCameraList : MonoBehaviour {
    private GameObject EventSystem;
    private Camera thisCamera;
	// Use this for initialization
	void Start () {
        Camera thisCamera = GameObject.Find(gameObject.name).GetComponent<Camera>();
        GameObject EventSystem = GameObject.Find("EventSystem");
        cameraChanger cameraChanger = EventSystem.GetComponent<cameraChanger>();
        cameraChanger.cameraList.Add(thisCamera);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
