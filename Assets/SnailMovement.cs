using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailMovement : MonoBehaviour {

    [SerializeField]
    float speed;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -(speed * Time.deltaTime), 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 60 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * 60 * Time.deltaTime);
        }
	}
}
