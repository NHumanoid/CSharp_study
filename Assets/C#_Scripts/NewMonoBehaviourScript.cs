using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
//Upsing.Unity Engine�� ���� �� public class NewMonoBehaviourScript : UnityEngine.MonoBehaviour �� ����մϴ�.
{
    // ���� �޼ҵ�
    void Start()
    {
        // Hello world ���
        Debug.Log("hello unity\n123456789");

        // �� ��� Proglam For �ݺ����� �̿� �� ����� (������ ���� ^��^)
        // Ex) �ּ��� ������ // �����ּ��� /* and */�� ����մϴ�!
        // Ex) �ٹٲ� ��������


        //���� ����� (���� ����)

        int a = 0;
        //    int b = 0; // <- a��� ������ ������ 0�� �������
        char c = '*'; // <- c��� ������ ������ *�� �������
        double d = 1.3; // <- d��� �Ҽ��� ������ 1.5�� �������
        bool AndOr = false; // <- AndOr�̶�� �ο����� ������ ������ ������� Ex) bool AndOR = true;

        Debug.Log("int�� ���� ->" + a + "char�� ���� ->" + c + "double�� �Ҽ� ->" + d);

        // int number1 = 0, number2 = 0, number3 = 0; <- �������� ��������

        // �Ʒ��� �������� ���������� ����
        // Ex)

        int e, f, g;

        e = 10;
        f = 10;
        g = 10;

        // e = f = g = 10; �ε� ���� ���� ��밡��

        Debug.Log(e + "," + f + "," + g);

        // ���� ������ ������� (���� �ٲ� �� ����� �Ф�)

        const int h = 0, i = 1;

        Debug.Log((h + i));

        // ���ǹ� if��

        if (AndOr == false)
        {
            Debug.Log("�����Դϴ�"); // ���� bool AndOr = false �̹Ƿ� �����Դϴ� ���
        }

        if (AndOr == true)
        {
            Debug.Log("���Դϴ�"); // ���� ������ ��� ����
        }


        /*
        for (a = 0; a < 5 ; a++)
        {
            for (b = 0 ; b < 5; b++ ) 
            {
                UnityEngine.Debug.Log("%d\n"+ a);
            }
        }
        */

        // C# ���� ���� (���)

        Debug.Log("�����->" + 5);
        Debug.Log("�����->" + (5 + 10));
        Debug.Log("�����->" + 5 + 10);

        // ���� ���� ���� (white spese)

        Debug.Log("a \b b");

        // ���� �׳� C��� ������-_-;
        // �������� ���� �ؾ� �� BACK SPASE...

        // ����ǥ '' or "" ����ϱ�
        // \"�� ����մϴ�.

        Debug.Log("\"������ ��µ�\" ^��^");
        Debug.Log("\'�߾߾߾߾߾߾ߝ������� \'");

        //���α׷��� �� �� TabŰ�� ����մϴ�~~~~~
        /*
        
        Ex)

        UnityEngine.Debug.Log("\"������ ��µ�\" ^��^");
            UnityEngine.Debug.Log("\"������ ��µ�\" ^��^"); <- �鿩���� ���� (TAB ���!)
        
         */

        int first = 10, second = 20, third = 30;

        Debug.Log(first + "," + second + "," + third + "\n" + "*/");

        //������ ��� ����

        /* int x = 1, y = 1, sun;

         for( x = 1; x < 10 ; x++)
         {
             for( y = 1 ; y < 10 ; y++ )
             {
                 UnityEngine.Debug.Log(x + "X" + y + "=" + (sun = x * y));
             }
         }
        */
        int numbr = 1;
        string accdsa = "���";

        Debug.Log($"{numbr}��{accdsa}�Դϴ�.");
        //�ܿ�� �� ��������������������������������������
        //����Ƽ������ �⺻���!

        int harp = 10;
        harp = harp++; // harp = harp + 1
        Debug.Log(harp);

        int unharp = 10;
        unharp = unharp--;
        Debug.Log(unharp);
        /*
                int min = 2;
                int max = 5;

                Debug.Log(min < max); //true��� (�ʰ�)
                Debug.Log(min > max); //false��� (�̸�)
                Debug.Log(min <= max); //true��� (�̻�)
                Debug.Log(min >= max); //false��� (����)

                Debug.Log(true || false); //true��� (OR)
                Debug.Log(true && false); //false��� (AND)
                Debug.Log(!false); //true ��� (NOT)
        */
        int numbers1 = 3;
        int numbers2 = 5;
        bool TandF = false;

        TandF = numbers1 == 3 && numbers2 != 3;
        Debug.Log(TandF); // true���

        int kor = 73, eng = 63, math = 90;
        int total = kor + eng + math;
        int ang = total / 3;

        Debug.Log($"����� ������ : {total} �̰� ����� ��������� {ang} �Դϴ�.");

        for (int k = 1; k <= 3; k++)
        {

            switch (k)
            {
                case 1:
                    if (kor >= 90)
                        Debug.Log($"����������{kor} 90�� �̻��̹Ƿ� A��� �Դϴ�.");
                    else if (kor >= 80)
                        Debug.Log($"����������{kor} 80�� �̻��̹Ƿ� B��� �Դϴ�.");
                    else if (kor >= 70)
                        Debug.Log($"����������{kor} 70�� �̻��̹Ƿ� C��� �Դϴ�.");
                    else if (kor >= 60)
                        Debug.Log($"����������{kor} 60�� �̻��̹Ƿ� D��� �Դϴ�.");
                    else
                        Debug.Log($"����������{kor} 60�� �̸��̹Ƿ� F��� �Դϴ�.");
                    break;


                case 2:
                    if (eng >= 90)
                        Debug.Log($"����������{eng} 90�� �̻��̹Ƿ� A��� �Դϴ�.");
                    else if (eng >= 80)
                        Debug.Log($"����������{eng} 80�� �̻��̹Ƿ� B��� �Դϴ�.");
                    else if (eng >= 70)
                        Debug.Log($"����������{eng} 70�� �̻��̹Ƿ� C��� �Դϴ�.");
                    else if (eng >= 60)
                        Debug.Log($"����������{eng} 60�� �̻��̹Ƿ� D��� �Դϴ�.");
                    else
                        Debug.Log($"����������{eng} 60�� �̸��̹Ƿ� F��� �Դϴ�.");
                    break;

                case 3:
                    if (math >= 90)
                        Debug.Log($"����������{math} 90�� �̻��̹Ƿ� A��� �Դϴ�.");
                    else if (math >= 80)
                        Debug.Log($"����������{math} 80�� �̻��̹Ƿ� B��� �Դϴ�.");
                    else if (math >= 70)
                        Debug.Log($"����������{math} 70�� �̻��̹Ƿ� C��� �Դϴ�.");
                    else if (math >= 60)
                        Debug.Log($"����������{math} 60�� �̻��̹Ƿ� D��� �Դϴ�.");
                    else
                        Debug.Log($"����������{math} 60�� �̸��̹Ƿ� F��� �Դϴ�.");
                    break;


            }

        }

        // �ݺ� �޼ҵ�
        void Update()
        {

        }
    }
}