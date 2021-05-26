using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public static bool play, fastForward, fastForward2, slowDown, gameIsPaused; //Används för att kontrollera tiden
    public float timescale = 1.0f; //Hur snabbt tiden normalt ska gå
    public float currentTime = 0.0f;

    private void Start()
    {
        currentTime += Time.deltaTime * timescale;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))  
        {
            slowDown = !slowDown;
            timescale = Time.timeScale = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            play = !play;
            timescale = Time.timeScale = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            fastForward = !fastForward;
            timescale = Time.timeScale = 1.5f;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            fastForward2 = !fastForward2;
            timescale = Time.timeScale = 2.0f;
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            timescale += Time.timeScale = 0.0f;
        }
        if(!gameIsPaused || !fastForward || !fastForward2 || !slowDown)
        {
            timescale += Time.timeScale = 1.0f;
        }
        
    }
}
