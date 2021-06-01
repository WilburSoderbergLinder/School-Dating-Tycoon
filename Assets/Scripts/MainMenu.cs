using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    

    public AudioSource audioSource;
    void Start()
    {
        //Musiken ska automatiskt börja spela -Saga
        audioSource.Play();
    }
    public void StopMusic()
    {
        //När man trycker på knappen ska det här uppfyllas, musiken ska sluta spela -Saga
        audioSource.Stop();
        print("Music Stop"); //För att försäkra
    }

    public void Play()
    {
        SceneManager.LoadScene(1);

    }
    public void Quit()
    {
        Quit();
    }

}
