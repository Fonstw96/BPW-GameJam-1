using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float forwardSpeed = 144;
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
        float accelerate = 0;
        if (Input.GetButton("Jump"))
            accelerate += forwardSpeed;

        transform.position += transform.forward * accelerate * Time.deltaTime;
        transform.Rotate(Input.GetAxis("Vertical") * risingSpeed * Time.deltaTime, Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime, 0);
    }
}
