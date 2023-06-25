using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballBody;
    public float ballSpeed = 200f;
    [SerializeField]
    private Text timerGo;

    private void Awake()
    {
        ballBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        StartCoroutine("ResetPosition");
    }

    void BallMovement()
    {
        // Random.value is a number between 0 and 1
        // If Random.value < 0.5 then x = -1, otherwise x = 1;
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);

        Vector2 ballDir = new Vector2(x, y);
        ballBody.AddForce(ballDir * ballSpeed);
    }

    public void AddForce(Vector2 force)
    {
        ballBody.AddForce(force);
    }

    public void ResetBallPos()
    {
        ballBody.position = Vector3.zero;
        ballBody.velocity = Vector3.zero;
    }

    public IEnumerator ResetPosition()
    {
        timerGo.text = "3";
        yield return new WaitForSeconds(0.7f);
        timerGo.text = "2";
        yield return new WaitForSeconds(0.7f);
        timerGo.text = "1";
        yield return new WaitForSeconds(0.7f);
        timerGo.text = "Go";
        yield return new WaitForSeconds(0.7f);
        timerGo.text = "";
        BallMovement();
    }
}
