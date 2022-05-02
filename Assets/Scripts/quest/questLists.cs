using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questLists : MonoBehaviour
{

    void Start()
    {
        if (questProgress.listsCreated != true)
        {
            //TAT(GCW) 1 N
            questProgress.tat1_L_N.Insert(0, questProgress.tat1_1_complete_L_N);
            questProgress.tat1_L_N.Insert(1, questProgress.tat1_2_complete_L_N);
            questProgress.tat1_L_N.Insert(2, questProgress.tat1_3_complete_L_N);
            questProgress.tat1_L_N.Insert(3, questProgress.tat1_4_complete_L_N);
            questProgress.tat1_L_N.Insert(4, questProgress.tat1_5_complete_L_N);
            questProgress.tat1_L_N.Insert(5, questProgress.tat1_6_complete_L_N);

            questProgress.tat1_D_N.Insert(0, questProgress.tat1_1_complete_D_N);
            questProgress.tat1_D_N.Insert(1, questProgress.tat1_2_complete_D_N);
            questProgress.tat1_D_N.Insert(2, questProgress.tat1_3_complete_D_N);
            questProgress.tat1_D_N.Insert(3, questProgress.tat1_4_complete_D_N);
            questProgress.tat1_D_N.Insert(4, questProgress.tat1_5_complete_D_N);
            questProgress.tat1_D_N.Insert(5, questProgress.tat1_6_complete_D_N);

            //TAT(GCW) 2 N
            questProgress.tat2_L_N.Insert(0, questProgress.tat2_1_complete_L_N);
            questProgress.tat2_L_N.Insert(1, questProgress.tat2_2_complete_L_N);
            questProgress.tat2_L_N.Insert(2, questProgress.tat2_3_complete_L_N);
            questProgress.tat2_L_N.Insert(3, questProgress.tat2_4_complete_L_N);
            questProgress.tat2_L_N.Insert(4, questProgress.tat2_5_complete_L_N);
            questProgress.tat2_L_N.Insert(5, questProgress.tat2_6_complete_L_N);

            questProgress.tat2_D_N.Insert(0, questProgress.tat2_1_complete_D_N);
            questProgress.tat2_D_N.Insert(1, questProgress.tat2_2_complete_D_N);
            questProgress.tat2_D_N.Insert(2, questProgress.tat2_3_complete_D_N);
            questProgress.tat2_D_N.Insert(3, questProgress.tat2_4_complete_D_N);
            questProgress.tat2_D_N.Insert(4, questProgress.tat2_5_complete_D_N);
            questProgress.tat2_D_N.Insert(5, questProgress.tat2_6_complete_D_N);

            //TAT(GCW) 3 N
            questProgress.tat3_L_N.Insert(0, questProgress.tat3_1_complete_L_N);
            questProgress.tat3_L_N.Insert(1, questProgress.tat3_2_complete_L_N);
            questProgress.tat3_L_N.Insert(2, questProgress.tat3_3_complete_L_N);
            questProgress.tat3_L_N.Insert(3, questProgress.tat3_4_complete_L_N);
            questProgress.tat3_L_N.Insert(4, questProgress.tat3_5_complete_L_N);
            questProgress.tat3_L_N.Insert(5, questProgress.tat3_6_complete_L_N);

            questProgress.tat3_D_N.Insert(0, questProgress.tat3_1_complete_D_N);
            questProgress.tat3_D_N.Insert(1, questProgress.tat3_2_complete_D_N);
            questProgress.tat3_D_N.Insert(2, questProgress.tat3_3_complete_D_N);
            questProgress.tat3_D_N.Insert(3, questProgress.tat3_4_complete_D_N);
            questProgress.tat3_D_N.Insert(4, questProgress.tat3_5_complete_D_N);
            questProgress.tat3_D_N.Insert(5, questProgress.tat3_6_complete_D_N);

            //TAT(GCW) 4 N
            questProgress.tat4_L_N.Insert(0, questProgress.tat4_1_complete_L_N);
            questProgress.tat4_L_N.Insert(1, questProgress.tat4_2_complete_L_N);
            questProgress.tat4_L_N.Insert(2, questProgress.tat4_3_complete_L_N);
            questProgress.tat4_L_N.Insert(3, questProgress.tat4_4_complete_L_N);
            questProgress.tat4_L_N.Insert(4, questProgress.tat4_5_complete_L_N);
            questProgress.tat4_L_N.Insert(5, questProgress.tat4_6_complete_L_N);

            questProgress.tat4_D_N.Insert(0, questProgress.tat4_1_complete_D_N);
            questProgress.tat4_D_N.Insert(1, questProgress.tat4_2_complete_D_N);
            questProgress.tat4_D_N.Insert(2, questProgress.tat4_3_complete_D_N);
            questProgress.tat4_D_N.Insert(3, questProgress.tat4_4_complete_D_N);
            questProgress.tat4_D_N.Insert(4, questProgress.tat4_5_complete_D_N);
            questProgress.tat4_D_N.Insert(5, questProgress.tat4_6_complete_D_N);

            //TAT(GCW) 5 N
            questProgress.tat5_L_N.Insert(0, questProgress.tat5_1_complete_L_N);
            questProgress.tat5_L_N.Insert(1, questProgress.tat5_2_complete_L_N);
            questProgress.tat5_L_N.Insert(2, questProgress.tat5_3_complete_L_N);
            questProgress.tat5_L_N.Insert(3, questProgress.tat5_4_complete_L_N);
            questProgress.tat5_L_N.Insert(4, questProgress.tat5_5_complete_L_N);
            questProgress.tat5_L_N.Insert(5, questProgress.tat5_6_complete_L_N);

            questProgress.tat5_D_N.Insert(0, questProgress.tat5_1_complete_D_N);
            questProgress.tat5_D_N.Insert(1, questProgress.tat5_2_complete_D_N);
            questProgress.tat5_D_N.Insert(2, questProgress.tat5_3_complete_D_N);
            questProgress.tat5_D_N.Insert(3, questProgress.tat5_4_complete_D_N);
            questProgress.tat5_D_N.Insert(4, questProgress.tat5_5_complete_D_N);
            questProgress.tat5_D_N.Insert(5, questProgress.tat5_6_complete_D_N);

            //TAT(GCW) 6 N
            questProgress.tat6_L_N.Insert(0, questProgress.tat6_1_complete_L_N);
            questProgress.tat6_L_N.Insert(1, questProgress.tat6_2_complete_L_N);
            questProgress.tat6_L_N.Insert(2, questProgress.tat6_3_complete_L_N);
            questProgress.tat6_L_N.Insert(3, questProgress.tat6_4_complete_L_N);
            questProgress.tat6_L_N.Insert(4, questProgress.tat6_5_complete_L_N);
            questProgress.tat6_L_N.Insert(5, questProgress.tat6_6_complete_L_N);

            questProgress.tat6_D_N.Insert(0, questProgress.tat6_1_complete_D_N);
            questProgress.tat6_D_N.Insert(1, questProgress.tat6_2_complete_D_N);
            questProgress.tat6_D_N.Insert(2, questProgress.tat6_3_complete_D_N);
            questProgress.tat6_D_N.Insert(3, questProgress.tat6_4_complete_D_N);
            questProgress.tat6_D_N.Insert(4, questProgress.tat6_5_complete_D_N);
            questProgress.tat6_D_N.Insert(5, questProgress.tat6_6_complete_D_N);
        }
    }
}
