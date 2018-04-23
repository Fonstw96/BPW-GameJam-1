using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float maxSpeed = 12;
    public float forwardAcceleration = 2;
    public float slowDownAcceleration = 1;
    public float steeringAcceleration = 3;
    private float currentForwardSpeed = 0;

	void Start ()
    {
		
	}

	void Update ()
    {
        GetInput();
        Move();

        print(currentForwardSpeed);
	}

    private void GetInput()
    {
        // Forward movement
        if (currentForwardSpeed < maxSpeed && Input.GetAxis("Vertical") > 0)
        {
            currentForwardSpeed += Input.GetAxis("Vertical") * forwardAcceleration;

            if (currentForwardSpeed > maxSpeed)
                currentForwardSpeed = maxSpeed;
        }
        else if (currentForwardSpeed > 0 && Input.GetAxis("Vertical") <= 0)
        {
            currentForwardSpeed -= slowDownAcceleration;

            if (currentForwardSpeed < 0)
                currentForwardSpeed = 0;
        }

        // Steering
        if (Input.GetAxis("Horizontal") != 0)
        {
            // steer
        }
    }

    private void Move()
    {
        transform.position += transform.forward * currentForwardSpeed;
    }
}
