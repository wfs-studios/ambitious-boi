using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.E))
        {
            float currentRotation = 90;
            Camera.main.transform.eulerAngles = new Vector3(0, 0, currentRotation);
            //transform.Rotate(Vector3.forward, currentRotation);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            float currentRotation = -90;
            transform.eulerAngles = new Vector3(0, 0, currentRotation);
        }
    }
}
