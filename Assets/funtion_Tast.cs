using System.Globalization;
using UnityEngine;

// public class funtion_Tast : UnityEngine.MonoBehaviour ����
public class funtion_Tast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] sscore = {90,70,10};
        string[] sstring = {"����","����","����"};

        for(int i = 0 ; i <= 2; i++)
        {
            Scorefuntion(sscore[i], sstring[i]); //����� ���ϴ� �Լ�����

        }

        /* int[,] streeang = new int[2, 3] { {1,2,3 },{4,5,6 } };

         Debug.Log($"�迭�� �ѱ��̴� {streeang.Length}�Դϴ�.");

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

    // ��� ���ϴ� �Լ�
    public static void Scorefuntion(int sscore, string sstring)
        {

        if (sscore >= 90)
        {
            Debug.Log($"{sscore}������ {sstring} �̰� A��� �Դϴ�.");
        }
        else if (sscore >= 80)
        {
            Debug.Log($"{sscore}������ {sstring} �̰� B��� �Դϴ�.");
        }
        else if (sscore >= 70)
        {
            Debug.Log($"{sscore}������ {sstring} �̰� C��� �Դϴ�.");
        }
        else if (sscore >= 60)
        {
            Debug.Log($"{sscore}������ {sstring} �̰� D��� �Դϴ�.");
        }
        else
        {
            Debug.Log($"{sscore}������ {sstring} �̰� ����(F)��� �Դϴ�.");
        }

    }
}
