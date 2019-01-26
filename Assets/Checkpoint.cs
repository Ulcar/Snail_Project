using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Checkpoint : MonoBehaviour {

    List<IResettable> objectsToReset = new List<IResettable>();
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnReset()
    {
        foreach (IResettable obj in objectsToReset)
        {
            obj.Reset();
        }
    }
}
