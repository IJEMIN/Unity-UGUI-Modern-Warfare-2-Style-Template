using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeManager : MonoBehaviour
{

    public CanvasGroup fadeHolder;

    public float fadeTime = 1.0f;
    private float fadeSpeed;

    public bool startWithFade = false;

    void Start()
    {
		fadeHolder.blocksRaycasts = false;
		fadeHolder.interactable = false;
		
        fadeSpeed = 1.0f / fadeTime;
        if (startWithFade)
        {
            FadeIn();
        }
    }

    public bool isFading
    {
        get;
        private set;
    }


    public void FadeIn()
    {
        StartCoroutine("StartFadeIn");
    }

    public void FadeOut()
    {
        StartCoroutine("StartFadeOut");
    }


    private IEnumerator StartFadeIn()
    {
        fadeHolder.blocksRaycasts = true;

        StopCoroutine("BlackFadeOut");

        fadeHolder.alpha = 1.0f;

        float currentTime = Time.time;

        while (currentTime + fadeTime > Time.time)
        {

            fadeHolder.alpha -= fadeSpeed * Time.deltaTime;

            yield return null;
        }

        fadeHolder.alpha = 0.0f;
        fadeHolder.blocksRaycasts = false;
    }

    private IEnumerator StartFadeOut()
    {
        fadeHolder.blocksRaycasts = true;

        StopCoroutine("BlackFadeIn");


        fadeHolder.alpha = 0.0f;

        float currentTime = Time.time;

        while (currentTime + fadeTime > Time.time)
        {
            fadeHolder.alpha += fadeSpeed * Time.deltaTime;
            yield return null;
        }

        fadeHolder.alpha = 1.0f;
        fadeHolder.blocksRaycasts = false;
    }
}