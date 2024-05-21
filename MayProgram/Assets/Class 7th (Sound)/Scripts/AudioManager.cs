using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{
    public Slider slider;
    public AudioClip[] audioClip;

    public AudioSource effectSource;
    public AudioSource scenerySource;

    private void Awake()
    {
        scenerySource.volume = slider.value;
    }

    public void Control(float volume)
    {
        scenerySource.volume = volume;
    }
    
    public void Sound(int audioValue)
    {
        // PlayOneShot : ���ÿ� ���� �������� ���带 ����ϴ� �Լ�
        effectSource.PlayOneShot(audioClip[audioValue]);
    }
}
