using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
  public  class BirdMovement:Enemy
    {
    [SerializeField]
    float distance = 2f;
    [SerializeField]
    float speed = 10f;
    bool moving = false;
    private void Update()
    {
        RaycastHit2D[] hits = Physics2D.LinecastAll(transform.position, new Vector2(transform.position.x, transform.position.y) + Vector2.right * distance);
        Debug.DrawLine(transform.position,new Vector2(transform.position.x, transform.position.y) +  Vector2.right * distance);

        foreach (RaycastHit2D hit in hits)
        {
            if (hit.transform.tag == "Snail" && !moving)
            {
                moving = true;
                StartCoroutine(MoveBird(2, 5));
            }
        }

       
    }

    IEnumerator MoveBird(float time, float cooldownTime)
    {
        float currentTime = 0;

        while (currentTime < time)
        {
            currentTime += Time.deltaTime;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            yield return null;
        }
        currentTime = 0;
        reset();

        while (currentTime < cooldownTime)
        {
            currentTime += Time.deltaTime;
            yield return null;
        }
        moving = false;
        

        yield return null;
    }
}
