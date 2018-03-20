using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {

	public void ExitGame()
	{
		DialoguePopup.instance.ShowPopup("Do you want Really Quit?",() => Application.Quit());
	}
}
