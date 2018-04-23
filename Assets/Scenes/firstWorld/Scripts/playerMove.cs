using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float maxForwardSpeed = 12;
    public float forwardAcceleration = 2;
    public float slowDownAcceleration = 1;
    private float currentForwardSpeed = 0;

    public float maxSteeringSpeed = 8;
    public float steeringAcceleration = 3;
    private float currentSteeringSpeed = 0;

    public float maxRaisingSpeed = 8;
    public float raisingAcceleration = 3;
    private float currentRaisingSpeed = 0;

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
        if (currentForwardSpeed < maxForwardSpeed && Input.GetButton("Jump"))
        {
            currentForwardSpeed += forwardAcceleration * Time.deltaTime;

            if (currentForwardSpeed > maxForwardSpeed)
                currentForwardSpeed = maxForwardSpeed;
        }
        else if (currentForwardSpeed > 0 && !Input.GetButton("Jump"))
        {
            currentForwardSpeed -= slowDownAcceleration * Time.deltaTime;

            if (currentForwardSpeed < 0)
                currentForwardSpeed = 0;
        }

        // Going left/right
        if (currentSteeringSpeed < maxSteeringSpeed && Input.GetAxis("Horizontal") != 0)
        {
            currentSteeringSpeed += Input.GetAxis("Horizontal") * steeringAcceleration * Time.deltaTime;

            if (currentSteeringSpeed > maxSteeringSpeed)
                currentSteeringSpeed = maxSteeringSpeed;
        }
    }

    private void Move()
    {
        transform.position += transform.forward * currentForwardSpeed;
        transform.Rotate(0, currentSteeringSpeed, 0);
    }
}
