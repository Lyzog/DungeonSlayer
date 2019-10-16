using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Joystick joystick;
    public Vector2 movement;

    void FixedUpdate()
    {
        //input
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
        

        //Flyttar gubbe om Joystick inte är 0, 0
        if(movement.x != 0 && movement.y != 0)
        {
            

            rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);


            //Vector3 tmp = movement;

            //transform.LookAt(Vector3.zero , -Vector3.forward); // fel här på denna rad
            //Vector3 difference = targetTRA.position - transform.position;
            float rotationZ = Mathf.Atan2(-movement.x, movement.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        }
    }
}
