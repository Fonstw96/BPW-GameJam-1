using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetProgress : MonoBehaviour
{
    public Text uiProgressText;
    public int totalIngredients = 7;

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
            int currentIngredients = other.GetComponent<PlayerCollisionScript>().IntIngredient1;
            uiProgressText.text = currentIngredients + " / " + totalIngredients;
        }
    }
}
