using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    Transform characterToFollow;
    [SerializeField]
    Vector3 offset;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(characterToFollow.position.x, characterToFollow.position.y, transform.position.z) + offset;
	}


}
