using UnityEngine;

public class MT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EEE.Pro(20);
        EEE.Pro1(50);
        funtion_Tast.Scorefuntion(50, "¼öÇÐ");

        System.Random random = new System.Random();

        Debug.Log(random.Next(5));
        Debug.Log(random.Next(10));

    }
}
