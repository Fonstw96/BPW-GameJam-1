using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour {

	public int IntIngredient1 = 1;
	public int IntIngredient2 = 1;
	public GameObject Ingredient1;
	public GameObject Ingredient2;
	public Rigidbody rb;
	private Vector3 planetBounce;

	// Use this for initialization

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ingredient1")){
			IntIngredient1 += 1;
		}

		if (other.gameObject.CompareTag ("Ingredient2")){
			IntIngredient2 += 1;
		}

	}


	void OnCollisionEnter(Collision collision){


		if (collision.gameObject.CompareTag ("Planet")){
			//lose materials 
			if (IntIngredient1 >= 1) {
				IntIngredient1 -= 1;
				Instantiate (Ingredient1, this.transform.position + new Vector3 (3,3,3), this.transform.rotation);
			}
			if (IntIngredient2 >= 1) {
				IntIngredient2 -= 1;
				Instantiate (Ingredient2, this.transform.position + new Vector3 (-3,3,-3), this.transform.rotation);
			}

			Vector3 planetBounce = new Vector3 (gameObject.transform.position.x + collision.transform.position.x, gameObject.transform.position.y + collision.transform.position.y ,gameObject.transform.position.z + collision.transform.position.z);

			rb.AddForce (transform.forward * 200);


		}
	}
}
