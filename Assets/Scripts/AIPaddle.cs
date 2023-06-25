using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
    public Rigidbody2D ballRB;
    public static bool IsSecondPlayer = false;
    private float AIReactionHardness;

    private void FixedUpdate()
    {
        if (IsSecondPlayer == false)
        {
            if(Options.isHard == false)
            {
                AIReactionHardness = -2f;
            }
            else
            {
                AIReactionHardness = -6f;
            }
            // velocity.x > 0 means, that it's moving to the right
            if (this.ballRB.velocity.x > 0f && this.ballRB.position.x > AIReactionHardness)
            {
                if (this.ballRB.position.y > this.transform.position.y)
                {
                    rigidBody.AddForce(Vector2.up * this.speed);
                }
                else if (this.ballRB.position.y < this.transform.position.y)
                {
                    rigidBody.AddForce(Vector2.down * this.speed);
                }
            }
            else
            {
                //if(timeRemaining > 0.8f)
                {
                    float rand = Random.value < 0.5f ? -1f : 1f;
                    if (rand == -1f)
                    {
                        rigidBody.AddForce(Vector2.down * this.speed);
                    }
                    else
                    {
                        rigidBody.AddForce(Vector2.up * this.speed);
                    }
                }
            }

        }
    }

    private Vector2 direction;

    private void Update()
    {
        if (IsSecondPlayer == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
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
}
