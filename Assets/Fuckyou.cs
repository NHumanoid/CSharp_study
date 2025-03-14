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
        string resuit = RE("네에네에네에");
        Debug.Log(resuit);
        Debug.Log(storng);
    }

    string RE(string ne) 
    {
        Debug.Log(ne);
        ne = "꺼저";
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
