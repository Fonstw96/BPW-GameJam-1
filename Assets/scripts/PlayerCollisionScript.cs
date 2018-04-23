using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour {

	public int IntIngredient1 = 0;
	public int IntIngredient2 = 0;
	public GameObject Ingredient1;
	public GameObject Ingredient2;
	public Rigidbody rb;
	private Vector3 planetBounce;



	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ingredient1")){
			IntIngredient1 += 1;
		}

		if (other.gameObject.CompareTag ("Ingredient2")){
			IntIngredient2 += 1;
			print (IntIngredient2);

		}

	}


	void OnCollisionEnter(Collision collision){


		if ((collision.gameObject.CompareTag ("Planet"))){
			//if (collision.relativeVelocity.magnitude > 1) {
				
				//lose materials 
				if (IntIngredient1 >= 1) {
					IntIngredient1 -= 1;
					Instantiate (Ingredient1, this.transform.position + new Vector3 (0, 15, 0), this.transform.rotation);
				}
				if (IntIngredient2 >= 1) {
					IntIngredient2 -= 1;
					Instantiate (Ingredient2, this.transform.position + new Vector3 (0, 15, 0), this.transform.rotation);
				}



			//}
		}
	}
}
