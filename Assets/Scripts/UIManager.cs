using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UIManager : MonoBehaviour {

	public static UIManager instance;

	void Awake () {
		instance = this;

	}

	void Start()
	{
		var selectable = FindObjectOfType<Selectable>();
		EventSystem.current.SetSelectedGameObject(selectable.gameObject);
	}
}
