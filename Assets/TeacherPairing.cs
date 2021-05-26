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
            int thingsInCommon = 0;

            for (int i = 0; i < teacher.traits.Length; i++)
            {
                if (teacher.traits[i] == pairedTeacher.traits[i]) thingsInCommon++;
            }

            if(thingsInCommon <= badScore)
            {
                print("Dålig matchning");
            }
            else if(thingsInCommon <= normalScore)
            {
                print("okej matchning");
            }
            else
            {
                print("Mycket bra matchning");
            }
        }
   }
}
