using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Fuckyou : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = -15, b = 10;
        int storng = Storonger(a, b);
        string resuit = RE("�׿��׿��׿�");
        Debug.Log(resuit);
        Debug.Log(storng);
    }

    string RE(string ne) 
    {
        Debug.Log(ne);
        ne = "����";
        return ne;
        
    }
    int Storonger(int a, int b)
    {
        if (a < 0)
        {
            a = -a;
            b = -b;

            return a;
            
        }
        else
        {
            return a;
        }

            

    }
}
