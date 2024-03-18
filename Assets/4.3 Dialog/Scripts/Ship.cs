using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
	public Rigidbody2D RB;
	public float MoveSpeed;

    private void FixedUpdate()
	{
		RB.MovePosition(RB.position + new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, 0f));
	}
}
