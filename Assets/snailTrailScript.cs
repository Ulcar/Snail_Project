using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snailTrailScript : MonoBehaviour {

    public LineRenderer trail;
    public EdgeCollider2D trailCollider;

    Vector3 lastEdgePosition = new Vector3();

   public float trailUpdateTime;
    private float currentTime = 0;
    bool busy = false;

    
    // Use this for initialization
	void Start () {
        trail.useWorldSpace = false;
	}



    // Update is called once per frame
    void Update()
    {
        if (busy)
        {
            currentTime += Time.deltaTime;
            if (currentTime > trailUpdateTime)
            {
                currentTime = 0;
                AddPointToTrail(transform.position);
            }
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            busy = false;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3[] emptyVector = { };
            Vector2[] emptyVector2 = { transform.position, transform.position};
            trail.SetPositions(emptyVector);
            trail.positionCount = 1;
            trailCollider.Reset();
            trailCollider.points = emptyVector2;
            trailCollider.isTrigger = true;
            trailCollider.edgeRadius = 0.4f;
            trail.SetPosition(0, transform.position);
            trail.SetPosition(1, transform.position);
            busy = true;
        }
    }


    void AddPointToTrail(Vector3 point)
    {
        if (point != lastEdgePosition)
        {
            List<Vector2> posList = new List<Vector2>();

            posList.AddRange(trailCollider.points);
            posList.Add(point);
            trailCollider.points = posList.ToArray();
            lastEdgePosition = point;
            List<Vector3> linePosList = new List<Vector3>();
            foreach (Vector2 pos in posList)
            {
                linePosList.Add(new Vector3(pos.x, pos.y));
            }
            if (linePosList.Count > 0)
            {
                trail.positionCount += 1;
                trail.SetPositions(linePosList.ToArray());
            }
        }
    }
}
