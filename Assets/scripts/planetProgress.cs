using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetProgress : MonoBehaviour
{
    public Text uiProgressText;
    public Image uiMyIngredient;

    public int totalIngredients = 7;
    public int myIngredientID;

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            int currentIngredients = other.GetComponent<PlayerCollisionScript>().IntIngredient[myIngredientID];
            uiProgressText.text = currentIngredients + " / " + totalIngredients;

            if (currentIngredients == totalIngredients)
                uiMyIngredient.color = Color.white;
        }
    }
}
