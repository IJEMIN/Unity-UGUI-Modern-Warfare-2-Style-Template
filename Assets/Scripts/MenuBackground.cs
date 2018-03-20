using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBackground : MonoBehaviour {

	private static Image m_backgroundImage;
	public Image backgroundImage;

	public static Sprite sprite {
		set {
			m_backgroundImage.sprite = value;
		}
	}

	void Awake()
	{
		m_backgroundImage = backgroundImage;
	}

}
