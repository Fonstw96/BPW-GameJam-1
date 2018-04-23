using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour {

	public int [] IntIngredient;
	public GameObject Ingredient1;
	public GameObject Ingredient2;
	public Rigidbody rb;
	private Vector3 planetBounce;

	// Use this for initialization
	void Start()
	{
		IntIngredient [1] = 1;
		IntIngredient [2] = 1;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ingredient1")){
			IntIngredient[1] += 1;
		}

		if (other.gameObject.CompareTag ("Ingredient2")){
			IntIngredient[2] += 1;
		}

	}


	void OnCollisionEnter(Collision collision){


		if (collision.gameObject.CompareTag ("Planet")){
			//lose materials 
			if (IntIngredient[1] >= 1) {
				IntIngredient[1] -= 1;
				Instantiate (Ingredient1, this.transform.position + new Vector3 (3,3,3), this.transform.rotation);
			}
			if (IntIngredient[2] >= 1) {
				IntIngredient[2] -= 1;
				Instantiate (Ingredient2, this.transform.position + new Vector3 (-3,3,-3), this.transform.rotation);
			}

			Vector3 planetBounce = new Vector3 (gameObject.transform.position.x + collision.transform.position.x, gameObject.transform.position.y + collision.transform.position.y ,gameObject.transform.position.z + collision.transform.position.z);

			rb.AddForce (planetBounce, ForceMode.Force);


		}
	}
}
