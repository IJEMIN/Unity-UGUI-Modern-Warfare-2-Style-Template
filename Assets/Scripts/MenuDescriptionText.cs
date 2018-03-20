using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class MenuDescriptionText : MonoBehaviour {

	private static Text text;

	public static string descriptions{
		set {
			text.text = value;
		}
	}

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text>();
	}

}
