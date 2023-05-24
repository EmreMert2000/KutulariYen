using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public Rigidbody ball;
    public float forwardForce = 500.0f;
    public float backwardForce = 250.0f;
    public float sideForce = 200.0f;
    public float forceMultiplier = 1.0f;

    private Vector3 fingerDownPosition;
    private Vector3 fingerUpPosition;
    private float minSwipeDistance = 20.0f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fingerDownPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                fingerUpPosition = touch.position;
                float distance = Vector3.Distance(fingerDownPosition, fingerUpPosition);
                if (distance > minSwipeDistance)
                {
                    Vector3 direction = fingerUpPosition - fingerDownPosition;
                    direction.Normalize();

                    float swipeForce = distance * forceMultiplier;

                    Vector3 forward = ball.transform.forward;
                    Vector3 right = ball.transform.right;

                    if (direction.y > 0)
                    {
                        ball.AddForce(forward * swipeForce * forwardForce);
                    }
                    else
                    {
                        ball.AddForce(forward * swipeForce * backwardForce);
                    }

                    if (direction.x > 0)
                    {
                        ball.AddForce(right * swipeForce * sideForce);
                    }
                    else
                    {
                        ball.AddForce(-right * swipeForce * sideForce);
                    }
                }
            }
        }
    }
}
