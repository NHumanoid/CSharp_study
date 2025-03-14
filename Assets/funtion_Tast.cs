using System.Globalization;
using UnityEngine;

// public class funtion_Tast : UnityEngine.MonoBehaviour 가능
public class funtion_Tast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] sscore = {90,70,10};
        string[] sstring = {"국어","영어","수학"};

        for(int i = 0 ; i <= 2; i++)
        {
            Scorefuntion(sscore[i], sstring[i]); //등수를 구하는 함수선언

        }

        /* int[,] streeang = new int[2, 3] { {1,2,3 },{4,5,6 } };

         Debug.Log($"배열의 총길이는 {streeang.Length}입니다.");

         for (int j = 0; j < streeang.GetLength(0); j++)
         {
             Debug.Log("===================================");
             for (int k = 0; k < streeang.GetLength(1); k++)
                 Debug.Log(streeang[j, k]);
         }
         

        int[,] atrings = new int[3, 3];
        for (int j = 0; j < 3; j++)
        {
            if (atrings[j, 0] == 0)
            {
                atrings[0, 0] = 1;
                Debug.Log(atrings[j, 0]);
            }
        }
        */
    }

    // 등수 구하는 함수
    public static void Scorefuntion(int sscore, string sstring)
        {

        if (sscore >= 90)
        {
            Debug.Log($"{sscore}점수는 {sstring} 이고 A등급 입니다.");
        }
        else if (sscore >= 80)
        {
            Debug.Log($"{sscore}점수는 {sstring} 이고 B등급 입니다.");
        }
        else if (sscore >= 70)
        {
            Debug.Log($"{sscore}점수는 {sstring} 이고 C등급 입니다.");
        }
        else if (sscore >= 60)
        {
            Debug.Log($"{sscore}점수는 {sstring} 이고 D등급 입니다.");
        }
        else
        {
            Debug.Log($"{sscore}점수는 {sstring} 이고 낙제(F)등급 입니다.");
        }

    }
}
