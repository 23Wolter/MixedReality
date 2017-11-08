using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEnter : MonoBehaviour {

    public float rotateSpeed = 5f; 

	// Use this for initialization
	void Start () {
        Debug.Log(transform.rotation);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        transform.rotation = rotation;//Quaternion.Lerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
        Debug.Log(transform.rotation); 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
