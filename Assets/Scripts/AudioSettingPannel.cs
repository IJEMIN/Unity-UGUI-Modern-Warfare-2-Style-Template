using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingPannel : MonoBehaviour
{
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider voiceSlider;
    public Slider effectSlider;

    bool isInitiated = false;


    void Awake ()
    {
        masterSlider.value = AudioManager.instance.masterVolume;
        voiceSlider.value = AudioManager.instance.voiceVolume;
        musicSlider.value = AudioManager.instance.musicVolume;
        effectSlider.value = AudioManager.instance.effectVolume;
        isInitiated = true;
    }

    public void UpdateVolume()
    {
        if(!isInitiated)
        {
            return;
        }
        AudioManager.instance.masterVolume = masterSlider.value;
        AudioManager.instance.voiceVolume = voiceSlider.value;
        AudioManager.instance.musicVolume = musicSlider.value;
        AudioManager.instance.effectVolume = effectSlider.value;
    }

}
