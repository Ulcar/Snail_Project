using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailMovement : MonoBehaviour {

    [SerializeField]
    float speed;

   public bool movement = false;
    Vector3 lastPosition;
    public Vector3 movementVector;
    public bool ForwardHit = false;
    public bool BackHit = false;
    [SerializeField]
    float distance = 2;

    // Use this for initialization
	void Start () {
        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit2D[] uphits = Physics2D.LinecastAll(transform.position, transform.position  + (transform.up * distance), 1 << LayerMask.NameToLayer("Walls"));
        Debug.DrawLine(transform.position, transform.position + (transform.up * distance));

        foreach (RaycastHit2D hit in uphits)
        {
            ForwardHit = true;
        }

        if (uphits.Length == 0)
        {
            ForwardHit = false;
        }

        RaycastHit2D[] downhits = Physics2D.LinecastAll(transform.position, transform.position + (transform.up * -1  * distance), 1 << LayerMask.NameToLayer("Walls"));
        Debug.DrawLine(transform.position, transform.position + (transform.up * -1  * distance));
        foreach (RaycastHit2D hit in downhits)
        {
            BackHit = true;
        }
        if (downhits.Length == 0)
        {
            BackHit = false;
        }
        if (Input.GetKey(KeyCode.W) && !ForwardHit)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            movement = true;
            movementVector = transform.position - lastPosition;
            lastPosition = transform.position;
        }

        else if (Input.GetKey(KeyCode.S) && !BackHit)
        {
            transform.Translate(new Vector3(0, -(speed * Time.deltaTime), 0));
            movementVector = lastPosition - transform.position;
            movement = true;
            lastPosition = transform.position;
        }

        else
        {
            movement = false;
        }
        if (Input.GetKey(KeyCode.A) && ((movementVector.x > 0 | movementVector.y > 0) | (movementVector.x < 0 | movementVector.y < 0)))
        {
            transform.Rotate(Vector3.forward * 60 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && ((movementVector.x > 0 | movementVector.y > 0) | (movementVector.x < 0 | movementVector.y < 0)))
        {
            transform.Rotate(Vector3.back * 60 * Time.deltaTime);
        }
	}
}
