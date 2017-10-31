using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePopup : MonoBehaviour {

    private Vector3 pos;
    private Vector3 oldPos; 
    private bool rotate;
    private MobileRotation mobileRotation;
    private bool mobileIsUp;

    public float moveSpeed; 

	// Use this for initialization
	void Start () {
        pos = transform.position;
        mobileIsUp = false; 
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1"))
        {
            if (!mobileIsUp)
            {
                MobileRotation.rotate = false;
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), moveSpeed * Time.deltaTime); 
                mobileIsUp = true; 
            } else
            {
                MobileRotation.rotate = true;
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z), moveSpeed * Time.deltaTime);
                mobileIsUp = false; 
            }
        }
	}
}
