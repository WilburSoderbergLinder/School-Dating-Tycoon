using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class Saves : MonoBehaviour
{
    public static Saves Instance { get; private set; }


    //Lista över värden som ska sparas över scripts.
    public int money = 0;
    public int students = 0;
    public int income = 100;

    private void Awake() //Gör scriptet till en Singleton
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }
}
