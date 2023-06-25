using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        // Without This else, it will slide contonuously
        else
        {
            direction = Vector2.zero;
        }

        if (direction.sqrMagnitude != 0)
        {
            rigidBody.AddForce(direction * this.speed);
        }
    }
}
