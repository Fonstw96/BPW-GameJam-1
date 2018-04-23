using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour {

	public int[] IntIngredient = new int[2];
	public GameObject Ingredient1;
	public GameObject Ingredient2;
	public Rigidbody rb;
	public AudioSource PickupSound;
	private Vector3 planetBounce;
    


    void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Ingredient1")){
			IntIngredient[0] += 1;
		}

		if (other.gameObject.CompareTag ("Ingredient2")){
			IntIngredient[1] += 1;
			print (IntIngredient[1]);


		}

	}


	//void OnCollisionEnter(Collision collision){


	//	if ((collision.gameObject.CompareTag ("Planet"))){
	//		//if (collision.relativeVelocity.magnitude > 1) {
				
	//			//lose materials 
	//			if (IntIngredient[0] >= 1) {
	//				IntIngredient[0] -= 1;
	//				Instantiate (Ingredient1, this.transform.position + new Vector3 (0, 15, 0), this.transform.rotation);
	//			}
	//			if (IntIngredient[1] >= 1) {
	//				IntIngredient[1] -= 1;
	//				Instantiate (Ingredient2, this.transform.position + new Vector3 (0, 15, 0), this.transform.rotation);
	//			}



	//		//}
	//	}
	//}
}
