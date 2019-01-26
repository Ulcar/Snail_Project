using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snailSpriteAnimator : MonoBehaviour {

    Animator animator;
    [SerializeField]
    SnailMovement movement;

    [SerializeField]
    SpriteRenderer sprite;

    float updateTime = 0.1f;
    float currentTime = 0;

    bool upMovement = false;
    bool sidewaysMovement = false;
    bool downMovement = false;
    // Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
      //  movement = GetComponent<SnailMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        if (movement.movement == true)
        {
            currentTime = 0;
            animator.SetBool("Movement", true);

            if ((movement.transform.rotation.z <= 0.5f) && movement.transform.rotation.z >= -0.5f)
            {
                if (!upMovement)
                {
                    animator.SetTrigger("Up");
                    upMovement = true;
                    sidewaysMovement = false;
                    downMovement = false;
                }
                transform.rotation = movement.transform.rotation;
                
            }
            else if ((movement.transform.rotation.z >= 0.6f && movement.transform.rotation.z <= 0.9f) || movement.transform.rotation.z <= -0.6f && movement.transform.rotation.z >= -0.9f)
            {
                if (!sidewaysMovement)
                {
                    animator.SetTrigger("Sideways");
                    sidewaysMovement = true;
                    downMovement = false;
                    upMovement = false;
                }
                Quaternion rotation = new Quaternion();
              
                if (movement.movementVector.x > 0)
                {
                    sprite.flipX = false;
                    rotation.eulerAngles = new Vector3(0, 0, movement.transform.rotation.eulerAngles.z - 270);

                }

                else
                {
                    sprite.flipX = true;
                   
                    rotation.eulerAngles = new Vector3(0, 0, movement.transform.rotation.eulerAngles.z - 90);
                }

                transform.rotation = rotation;

            }

            else if ((movement.transform.rotation.z >= 0.9f && movement.transform.rotation.z <= 1f) || (movement.transform.rotation.z <= -0.9f && movement.transform.rotation.z >= -1f))
            {
                if (!downMovement)
                {
                    downMovement = true;
                    upMovement = false;
                    sidewaysMovement = false;
                    animator.SetTrigger("Down");
                }

                Quaternion rotation = new Quaternion();
            //    if (movement.transform.rotation.z >= 0.9f && movement.transform.rotation.z <= 1f)
                {
                    rotation.eulerAngles = new Vector3(0, 0, movement.transform.rotation.eulerAngles.z - 180);
                    transform.rotation = rotation;
           //     }

          //      else
           ////     {

                }
            }
        }

        else
        {
            animator.SetBool("Movement", false);
        }
       
    }
}
