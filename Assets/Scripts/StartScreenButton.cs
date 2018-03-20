using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartScreenButton : MonoBehaviour,ISelectHandler,IDeselectHandler,IPointerEnterHandler {

	private Image buttonImage;
	public Sprite highlightedSprite;
	public Sprite idleSprite;
	public Sprite backgroundSprite;
	public string descriptions;


	void Awake()
	{
		buttonImage = GetComponent<Image>();
		buttonImage.sprite = idleSprite;
	}
	public void OnSelect(BaseEventData data)
	{
		MenuBackground.sprite = backgroundSprite;
		buttonImage.sprite = highlightedSprite;
		MenuDescriptionText.descriptions = descriptions;
		AudioManager.instance.PlayButtonSound();
	}

	public void OnDeselect(BaseEventData data)
	{
		buttonImage.sprite = idleSprite;
	}

	public void OnPointerEnter(PointerEventData data)
	{
		EventSystem.current.SetSelectedGameObject(gameObject);
	}


}
