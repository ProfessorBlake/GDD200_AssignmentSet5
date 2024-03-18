using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
	private float speed = 0f;

	private void Update()
	{
		transform.Rotate(new Vector3(speed, speed, speed) * Time.deltaTime);
	}

	public void SetSpinSpeed(float newSpeed)
	{
		speed = newSpeed;
	}
}
