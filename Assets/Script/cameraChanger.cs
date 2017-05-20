using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class cameraChanger : MonoBehaviour {
    public List<Camera> cameraList = new List<Camera>();
    public int whichCamera;

	// Use this for initialization
	void Start () {
        foreach (Camera i in cameraList)
        {
            i.enabled = false;
            AudioListener audioListenerOff = i.GetComponent(typeof(AudioListener)) as AudioListener;
            audioListenerOff.enabled = false;
        }
        AudioListener audioListener = cameraList[whichCamera].GetComponent(typeof(AudioListener)) as AudioListener;
        audioListener.enabled = true;
        cameraList[whichCamera].enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            cameraList[whichCamera].enabled = true;
            AudioListener audioListener = cameraList[whichCamera].GetComponent(typeof(AudioListener)) as AudioListener;
            audioListener.enabled = true;
            List<Camera> camerasOff = cameraList.Where((v, i) => i != whichCamera).ToList();
            foreach (Camera i in camerasOff)
            {
                i.enabled = false;
                AudioListener audioListenerOff = i.GetComponent(typeof(AudioListener)) as AudioListener;
                audioListenerOff.enabled = false;
            }
            if (whichCamera == cameraList.Count - 1)
            {
                whichCamera = 0;
            }
            else
            {
                whichCamera++;
            }
        }

    }
}
