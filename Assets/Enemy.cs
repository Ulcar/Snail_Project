using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    public abstract class Enemy:MonoBehaviour
    {
    Vector3 startPosition;
    Quaternion startRotation;


    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
    protected void reset()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}
