using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreen : MonoBehaviour
{
    public static Stack<UIScreen> frameStack = new Stack<UIScreen>();
    public Animator screenAnimator;

    public bool startScreen;

    public void Awake()
    {
        if (startScreen)
        {
            ShowScreen();
        }
    }

    public void ShowScreen()
    {
        if (frameStack.Count > 0)
        {
            var lastScreen = frameStack.Pop();
            lastScreen.gameObject.SetActive(false);
            frameStack.Push(lastScreen);
        }

        gameObject.SetActive(true);
        frameStack.Push(this);


        if (screenAnimator != null)
        {
            screenAnimator.SetTrigger("On");
        }
    }

    public void CloseScreenAndReturn()
    {
        frameStack.Pop().gameObject.SetActive(false);

        var lastScreen = frameStack.Pop();
        lastScreen.gameObject.SetActive(true);
        frameStack.Push(lastScreen);
    }
}
