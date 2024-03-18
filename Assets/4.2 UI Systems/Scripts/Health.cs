using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public Transform HealthIconContainer;

	public int health = 1;

	public void ModifyHealth(int hpChange)
	{
		if (health + hpChange >= 0 && health + hpChange <= HealthIconContainer.childCount)
		{
			health += hpChange;

			for(int i = 0; i < HealthIconContainer.childCount; i++)
			{
				if (i < health)
					HealthIconContainer.GetChild(i).gameObject.SetActive(true);
				else
					HealthIconContainer.GetChild(i).gameObject.SetActive(false);
			}
		}
	}
}
