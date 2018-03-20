using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialoguePopup : MonoBehaviour {

	public static DialoguePopup instance;
	public GameObject holder;
	public Button yesButton;
	public Text descriptionText;

	void Awake()
	{
		instance = this;
		ClosePopup();
	}

	public void ShowPopup(string descriptions, UnityAction callback)
	{
		descriptionText.text = descriptions;
		yesButton.onClick.RemoveAllListeners();
		yesButton.onClick.AddListener(callback);
		yesButton.onClick.AddListener(() => ClosePopup());
		holder.SetActive(true);
	}


	public void ClosePopup()
	{
		holder.SetActive(false);
	}

}
