using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
	public string PlayerName;
	public int PlayerGold;
	public TMP_Text PopupText;
	public Toggle MyToggle;

	private bool toggleState;
	private float sliderVal;
	private int dropVal;

	private void Start()
	{
		MyToggle.isOn = toggleState;

		UpdateText();
	}

	private void UpdateText()
	{
		PopupText.text = "Welcome " + PlayerName + ". You have " + PlayerGold +
			" gold! \n Toggle: " + toggleState + "\n Slider: " + sliderVal +
			"\n Dropdown: " + dropVal;
	}

	public void SetToggleState(bool newState)
	{
		toggleState = newState;
		UpdateText();
	}

	public void GetSliderValue(float value)
	{
		sliderVal = value;
		UpdateText();
	}

	public void GetDropdownValue(int value)
	{
		dropVal = value;
		if(value == 1)
		{
			PlayerGold -= 5;
		}
		else if (value == 2)
		{
			PlayerGold -= 10;
		}
		else if (value == 3)
		{
			PlayerGold -= 20;
		}
		UpdateText();
	}
}
