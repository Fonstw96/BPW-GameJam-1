using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float maxForwardSpeed = 12;
    public float forwardAcceleration = 2;
    public float forwardBrake = 1;
    private float currentForwardSpeed = 0;

    public float maxSteeringSpeed = 8;
    public float steeringAcceleration = 3;
    public float steeringBrake = .6667f;
    private float currentSteeringSpeed = 0;

    public float maxRaisingSpeed = 8;
    public float raisingAcceleration = 3;
    public float raisingBrake = .6667f;
    private float currentRaisingSpeed = 0;

    void Start ()
    {
		
	}

	void Update ()
    {
        GetInput();
        Move();
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
            currentForwardSpeed -= forwardBrake * Time.deltaTime;

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
        else if (Input.GetAxis("Horizontal") == 0)
        {
            if (currentSteeringSpeed > 0)
            {
                currentSteeringSpeed -= steeringBrake * Time.deltaTime;

                if (currentSteeringSpeed < 0)
                    currentSteeringSpeed = 0;
            }
            else if (currentSteeringSpeed < 0)
            {
                currentSteeringSpeed += steeringBrake * Time.deltaTime;

                if (currentSteeringSpeed > 0)
                    currentSteeringSpeed = 0;
            }
        }

        // Going up/down
        if (currentRaisingSpeed < maxRaisingSpeed && Input.GetAxis("Vertical") != 0)
        {
            currentRaisingSpeed += Input.GetAxis("Vertical") * raisingAcceleration * Time.deltaTime;

            if (currentRaisingSpeed > maxRaisingSpeed)
                currentRaisingSpeed = maxRaisingSpeed;
        }
        else if (Input.GetAxis("Vertical") == 0)
        {
            if (currentRaisingSpeed > 0)
            {
                currentRaisingSpeed -= raisingBrake* Time.deltaTime;

                if (currentRaisingSpeed < 0)
                    currentRaisingSpeed = 0;
            }
            else if (currentRaisingSpeed < 0)
            {
                currentRaisingSpeed += raisingBrake * Time.deltaTime;

                if (currentRaisingSpeed > 0)
                    currentRaisingSpeed = 0;
            }
        }
    }

    private void Move()
    {
        transform.position += transform.forward * currentForwardSpeed;
        transform.Rotate(currentRaisingSpeed, currentSteeringSpeed, 0);
    }
}
