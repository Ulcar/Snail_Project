using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour {

    bool inRange = false;

    [SerializeField]
    SOTester parser;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            parser.enabled = true;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SnailMovement>() != null)
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<SnailMovement>() != null)
        {
            inRange = false;
        }
    }
}
