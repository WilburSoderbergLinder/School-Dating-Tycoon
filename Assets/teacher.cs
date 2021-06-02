using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teacher : MonoBehaviour
{
    public Vector2 destination;
    public float minutes;
    private void Update()
    {
        minutes += Time.deltaTime*TimeSystem.Instance.timeScale; // behövde återskapa en del av tidsystemet för att kunna ha tillgång till det utan att skapa en referens - Gustav
        if (minutes >= 60) {
            minutes = 0;
            destination = new Vector2(Random.Range(-50, 50), Random.Range(-50, 50)); //skapar en slumpmässig destination -  Gustav
    }
    }
}
