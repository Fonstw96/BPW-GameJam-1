using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winScreen : MonoBehaviour
{
    public Image[] uiIngredients;
    public GameObject thethingyouwinwith;

	void Start ()
    {
		
	}

	void Update ()
    {
        int completed = 0;
        foreach (Image ingredient in uiIngredients)
        {
            if (ingredient.color == Color.white)
                completed++;
        }

        if (completed == uiIngredients.Length)
            thethingyouwinwith.SetActive(true);
	}
}
