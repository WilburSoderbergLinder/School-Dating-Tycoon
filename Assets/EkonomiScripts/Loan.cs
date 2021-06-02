using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loan : MonoBehaviour
{
    public int loanSize;
    int loan;
    public float interest;
    public float mortgageRate;



    public void PayMortgage()
    {
        
        loan -= Mathf.FloorToInt(loanSize * mortgageRate);
        Saves.Instance.money -= Mathf.FloorToInt(loanSize * mortgageRate);


        if (loan <= 0)
        {
            loanSize = 0;
            loan = 0;
            interest = 0;
            mortgageRate = 0;
            Destroy(this);
        }
    }
    public void SetLoan()
    {
        loan = Mathf.FloorToInt(loanSize*interest);
    }
}
