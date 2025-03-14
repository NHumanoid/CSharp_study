using UnityEngine;

public class EEE
{
    public static void Pro(int a)
    {
        Debug.Log($"{a} 정적 메서드");
    }

    public static void Pro1(int a)
    {
        Debug.Log($"{a} 인스턴스 메소드");
    }
    
}
