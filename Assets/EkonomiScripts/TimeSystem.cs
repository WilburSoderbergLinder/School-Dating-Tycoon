using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public static TimeSystem Instance { get; private set; } //För att använda function är det bara att skriva TimeSystem.timeScale

    public bool paused;         //Bool för om spelet är pausat eller ej
    public float savedTime;     //Sparar tid när man pausar.
    public float timeScale = 1.0f;  //Hur snabbt tiden går

    private void Awake() //Gör scriptet till en Singleton
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }


    public void PausePlay()
    {
        if (paused)
        {
            Play();
            paused = false;
        } else
        {
            Pause();
            paused = true;
        }

    }
    public void Play()
    {
        timeScale = savedTime;
    }

    public void Pause()
    {
        savedTime = timeScale;
        timeScale = 0;
    }

    public void Speed(float i)
    {
        timeScale = i;
    }


}
