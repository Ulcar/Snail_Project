using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailCollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Islowable slowable = collision.gameObject.GetComponent<Islowable>();
        if (slowable != null)
        {
            slowable.MovementSpeed = 0.1f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Islowable slowable = collision.gameObject.GetComponent<Islowable>();
        if (slowable != null)
        {
            slowable.MovementSpeed = 1f;
        }
    }
}
