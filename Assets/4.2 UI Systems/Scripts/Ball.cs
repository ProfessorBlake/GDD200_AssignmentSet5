using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
	public Vector3 MoveVector;
	public Image HealthBar;
	public int Gold = 0;
	public Text GoldText;

	private void Start()
	{
		GoldText.text = "Gold: " + Gold.ToString();
	}

	private void Update()
	{
		HealthBar.fillAmount = Mathf.Max(0f, HealthBar.fillAmount - Time.deltaTime * 0.2f); //Subtract healthbar

		if(HealthBar.fillAmount > 0f)
		{
			transform.position += MoveVector * Time.deltaTime; //Move
		}
		else
		{
			transform.position += MoveVector * Time.deltaTime * 0.2f; //Move
		}
	}

	public void UpdateHorizontal(float newVector)
	{
		MoveVector.x = newVector;
	}

	public void UpdateVertical(float newVector)
	{
		MoveVector.y = newVector;
	}

	public void BuyItem(int itemNumber)
	{
		int cost = 0;

		if(itemNumber == 1)
		{
			cost = 5;
		}
		else if(itemNumber == 2)
		{
			cost = 20;
		}
		else if(itemNumber == 3)
		{
			cost = 50;
		}

		if(Gold >= cost)
		{
			Gold -= cost;
			GoldText.text = "Gold: " + Gold.ToString();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Gold += 1;
		GoldText.text = "Gold: " + Gold.ToString();
		collision.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-5f, 5f));
		HealthBar.fillAmount = 1f;
	}
}
