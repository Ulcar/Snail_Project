using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyMovementCode : MonoBehaviour, Islowable {

    [SerializeField]
    Transform target;

    [SerializeField]
    float speed = 15f;

    [SerializeField]
    float MovementSpeed = 5f;

    float Islowable.MovementSpeed
    {
        get
        {
            return MovementSpeed;
        }

        set
        {
            MovementSpeed = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);

        transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);

        

    }
}
