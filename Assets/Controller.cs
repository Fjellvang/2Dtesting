using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float speed = 10f;
    Transform trans;
	// Use this for initialization
	void Start () {
        trans = GetComponent<Transform>();
        //Debug.Log(transform.position.x);
        //GetComponentInChildren<Transform>()
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Vector3.forward);
        //Input.GetAxis("X-Axis");
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, 1), speed);
            //transform.RotateAround(new Vector3(0, 0, 1), speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, 1), -speed);
            //transform.RotateAround(new Vector3(0, 0, 1), speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(1, 0, 0), speed);
            //transform.RotateAround(new Vector3(0, 0, 1), speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(1, 0, 1), -speed);
            //transform.RotateAround(new Vector3(0, 0, 1), speed);
        }
    }
}
