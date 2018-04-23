using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float maxForwardSpeed = 144;
    private float currentForwardSpeed = 0;
    public float accelerationTime = 4;
    public float risingSpeed = 144;
    public float steeringSpeed = 144;

    void Start ()
    {
		
	}

	void Update ()
    {
        Move();
	}

    private void Move()
    {
        if (Input.GetButton("Jump"))
            currentForwardSpeed += maxForwardSpeed / accelerationTime;
        else if (currentForwardSpeed > 0)
            currentForwardSpeed -= maxForwardSpeed / accelerationTime;
        else if (currentForwardSpeed < 0)
            currentForwardSpeed = 0;

        transform.position += transform.forward * currentForwardSpeed * Time.deltaTime;
        transform.Rotate(Input.GetAxis("Vertical") * risingSpeed * Time.deltaTime, Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime, 0);
    }
}
