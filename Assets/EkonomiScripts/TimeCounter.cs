﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Kod av Daniel
[RequireComponent(typeof(TimeSystem))]
public class TimeCounter : MonoBehaviour
{
    Loan[] loans = new Loan[5];

    public float minutes = 0;
    public int hours = 0;
    public int days = 0;
    public int weeks = 0;
    public int months = 0;
    public int years = 0;

    // Update is called once per frame
    void Update()
    {
        minutes += Time.deltaTime * TimeSystem.Instance.timeScale; //Time.deltaTime kommer att multipliceras med en variabel som kommer från ett annat script, jag har inte tillgång till den än. - Daniel

        if (minutes >= 60) //Lägger till ett värde på "hours" om "minutes" är lika med eller större än 60. - Daniel
        {
            hours++;
            minutes -= 60;
        }

        if (hours >= 24) //Lägger till ett värde på "days" om "hours" är lika med eller större än 24. - Daniel
        {
            days++;
            hours = 0;
        }

        if (days >= 7) //Lägger till ett värde på "weeks" om "days" är lika med eller större än 7. - Daniel
        {
            weeks++;
            days = 0;
        }

        if (weeks >= 4) //Lägger till ett värde på "months" om "weeks" är lika med eller större än 4. - Daniel
        {
            months++;
            weeks = 0;
            NewMonth();
        }

        if (months >= 12) //Lägger till ett värde på "years" om "months" är lika med eller större än 12. - Daniel
        {
            years++;
            months = 0;
        }

    }

    public void NewMonth()
    {
        Saves.Instance.money += Saves.Instance.students * Saves.Instance.income;
        foreach (Loan item in loans)
        {
            item.PayMortgage();
        }
    }

    public void UINewLoan(int loanSize)
    {
        NewLoan(loanSize, 1.1f, 0.1f);
    }

    public void NewLoan(int loanSize, float interest, float mortgageRate)
    {

        foreach (Loan i in loans)
        {
            
        }
        for (int i = 0; i < loans.Length; i++)
        {
            if (loans[i] == null)
            {
                //tomt
                loans[i] = gameObject.AddComponent<Loan>();
                loans[i].loanSize = loanSize;
                Saves.Instance.money += loanSize;
                loans[i].interest = interest;
                loans[i].mortgageRate = mortgageRate;
                loans[i].SetLoan();
                print("nytt Lån");
                return;
            }
        }
        print("för många");
        //För många
    }
}
