using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    public abstract class Enemy:MonoBehaviour, IResettable
    {
    Vector3 startPosition;
    Quaternion startRotation;



    void IResettable.Reset()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}
