using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherPairing : MonoBehaviour
{
    TeacherTraits pairedTeacher = null;

    [SerializeField] float badScore = 0;
    [SerializeField] float normalScore = 0;

   public void Pair(TeacherTraits teacher)
   {
        if(pairedTeacher == null)
        {
            pairedTeacher = teacher;
        }
        else
        {
            if (pairedTeacher == teacher) return;

            int thingsInCommon = 0;

            for (int i = 0; i < teacher.traits.Length; i++)
            {
                if (teacher.traits[i] == pairedTeacher.traits[i]) thingsInCommon++;
            }

            

            if(thingsInCommon <= badScore)
            {
                print("Dålig matchning");

                teacher.symbol.rend.sprite = teacher.symbol.badSymbol;
                pairedTeacher.symbol.rend.sprite = teacher.symbol.badSymbol;

                TimeCounter.Instance.NewBuff(-0.1f);

            }
            else if(thingsInCommon <= normalScore)
            {
                print("okej matchning");

                teacher.symbol.rend.sprite = teacher.symbol.normalSymbol;
                pairedTeacher.symbol.rend.sprite = teacher.symbol.normalSymbol;

                TimeCounter.Instance.NewBuff(0.1f);
            }
            else
            {
                print("Mycket bra matchning");

                teacher.symbol.rend.sprite = teacher.symbol.goodSymbol;
                pairedTeacher.symbol.rend.sprite = teacher.symbol.goodSymbol;

                TimeCounter.Instance.NewBuff(0.4f);
            }

            teacher.DestroyTeacher();
            pairedTeacher.DestroyTeacher();

            pairedTeacher = null;

        }
   }
    
    
}
