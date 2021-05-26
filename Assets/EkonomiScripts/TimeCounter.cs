using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Kod av Daniel
public class TimeCounter : MonoBehaviour
{

    float minutes = 0;
    int hours = 0;
    int days = 0;
    int weeks = 0;
    int months = 0;
    int years = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        minutes += Time.deltaTime; //Time.deltaTime kommer att multipliceras med en variabel som kommer från ett annat script, jag har inte tillgång till den än. - Daniel

        if (minutes >= 60) //Lägger till ett värde på "hours" om "minutes" är lika med eller större än 60. - Daniel
        {
            hours++;
            print(hours);
            minutes -= 60;
        }

        if (hours >= 24) //Lägger till ett värde på "days" om "hours" är lika med eller större än 24. - Daniel
        {
            days++;
            print(days);
            hours = 0;
        }

        if (days >= 7) //Lägger till ett värde på "weeks" om "days" är lika med eller större än 7. - Daniel
        {
            weeks++;
            print(weeks);
            days = 0;
        }

        if (weeks >= 4) //Lägger till ett värde på "months" om "weeks" är lika med eller större än 4. - Daniel
        {
            months++;
            print(months);
            weeks = 0;
            NewMonth();
        }

        if (months >= 12) //Lägger till ett värde på "years" om "months" är lika med eller större än 12. - Daniel
        {
            years++;
            print(years);
            months = 0;
        }

    }

    public void NewMonth()
    {
        Saves.Instance.money += Saves.Instance.students * Saves.Instance.income;
    }
}
