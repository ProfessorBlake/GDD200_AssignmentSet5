using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armor : MonoBehaviour
{
	public Image ArmorImage;

	// Because this function has a bool parameter and the Toggle component can pass a bool (checked/unchecked)
	// we can select the Dynamic Bool option from the On Value Changed field on the Toggle component.
	public void ToggleArmorImage(bool isActive)
	{
		ArmorImage.enabled = isActive;
	}
}
