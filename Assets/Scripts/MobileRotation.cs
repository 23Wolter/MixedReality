using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileRotation : MonoBehaviour {

    public GameObject camera;
    public static bool rotate; 
    public float rotateSpeed = 5f; 

	// Use this for initialization
	void Start () {
        rotate = true; 
	}
	
	// Update is called once per frame
	void Update () {
        if (rotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, camera.transform.rotation, rotateSpeed * Time.deltaTime);
        }
	}
}
