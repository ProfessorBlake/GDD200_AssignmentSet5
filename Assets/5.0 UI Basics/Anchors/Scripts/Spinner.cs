using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
	private bool isSpinning = false;

	private void Update()
	{
		if(isSpinning)
		{
			transform.Rotate(new Vector3(5f, 10f, 20f) * Time.deltaTime);
		}
	}

	public void ToggleSpin()
	{
		isSpinning = !isSpinning; // Toggle a bool between true and false.
		Debug.Log("Spinner: " + isSpinning);
	}
}
