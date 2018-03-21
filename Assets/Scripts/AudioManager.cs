using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance
    {
        get
        {
            if (m_instance)
            {
                return m_instance;
            }
            else
            {
                Debug.LogWarning("No AudioManager Found!");
                return null;
            }
        }
    }
    private static AudioManager m_instance;

    public AudioMixer mix;
    public AudioClip defaultButtonClip;

    public AudioSource musicAudio;
    public AudioSource buttonAudio;

    public float masterVolume
    {
        get
        {
            var volume = PlayerPrefs.GetFloat("Master Volume", 0f);

            mix.SetFloat("Master Volume", volume);
            return volume;
        }
        set
        {
            PlayerPrefs.SetFloat("Master Volume", value);
            mix.SetFloat("Master Volume", value);
        }
    }

    public float voiceVolume
    {
        get
        {
            var volume = PlayerPrefs.GetFloat("Voice Volume", 0f);

            mix.SetFloat("Voice Volume", volume);
            return volume;
        }
        set
        {
            PlayerPrefs.SetFloat("Voice Volume", value);
            mix.SetFloat("Voice Volume", value);
        }
    }

    public float effectVolume
    {
        get
        {
            var volume = PlayerPrefs.GetFloat("Effect Volume", 0f);

            mix.SetFloat("Effect Volume", volume);
            return volume;
        }
        set
        {
            PlayerPrefs.SetFloat("Effect Volume", value);
            mix.SetFloat("Effect Volume", value);
        }
    }

    public float musicVolume
    {
        get
        {
            var volume = PlayerPrefs.GetFloat("Music Volume", 0f);

            mix.SetFloat("Music Volume", volume);
            return volume;
        }
        set
        {
            PlayerPrefs.SetFloat("Music Volume", value);
            mix.SetFloat("Music Volume", value);
        }
    }

    void Setup()
    {
        musicVolume = musicVolume;
        masterVolume = masterVolume;
        effectVolume = effectVolume;
        voiceVolume = voiceVolume;
    }

    void Start()
    {
        Setup();
    }

    void Awake()
    {
        if (m_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            m_instance = this;
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        musicAudio.clip = clip;
        musicAudio.Play();
    }

    public void ResumeMusic()
    {
        musicAudio.Play();
    }

    public void StopMusic()
    {
        musicAudio.Stop();
    }

    public void PlayButtonSound()
    {
        buttonAudio.clip = defaultButtonClip;
        buttonAudio.Play();
    }
    public void PlayButtonSound(AudioClip clip)
    {
        buttonAudio.clip = clip;
        buttonAudio.Play();
    }

}
