using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
   public class SnailBody:MonoBehaviour
    {
    [SerializeField]
    Transform nextPart;
    [SerializeField]
    bool moving = false;
    [SerializeField]
    float speed = 5f;

    private void Update()
    {
        Vector3 v3FromLeader = transform.position - nextPart.position;
        v3FromLeader = v3FromLeader.normalized * transform.localScale.y;
        transform.position = v3FromLeader + nextPart.transform.position;
    }
}
