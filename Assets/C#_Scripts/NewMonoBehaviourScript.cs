using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
//Upsing.Unity Engine이 없을 때 public class NewMonoBehaviourScript : UnityEngine.MonoBehaviour 를 사용합니다.
{
    // 시작 메소드
    void Start()
    {
        // Hello world 출력
        Debug.Log("hello unity\n123456789");

        // 별 출력 Proglam For 반복문을 이용 한 별출력 (망했음 ㅅㅂ ^오^)
        // Ex) 주석은 한줄은 // 문장주석은 /* and */을 사용합니다!
        // Ex) 줄바꿈 문법연습


        //변수 만들기 (변수 선언)

        int a = 0;
        //    int b = 0; // <- a라는 정수형 변수에 0을 집어넣음
        char c = '*'; // <- c라는 문자형 변수에 *을 집어넣음
        double d = 1.3; // <- d라는 소수형 변수에 1.5를 집어넣음
        bool AndOr = false; // <- AndOr이라는 부울형에 변수에 거짓을 집어넣음 Ex) bool AndOR = true;

        Debug.Log("int는 정수 ->" + a + "char는 문자 ->" + c + "double은 소수 ->" + d);

        // int number1 = 0, number2 = 0, number3 = 0; <- 연속으로 변수선언

        // 아래의 연속으로 변수선언의 예시
        // Ex)

        int e, f, g;

        e = 10;
        f = 10;
        g = 10;

        // e = f = g = 10; 로도 변수 지정 사용가능

        Debug.Log(e + "," + f + "," + g);

        // 정수 형식의 상수선언 (수를 바꿀 수 없어요 ㅠㅠ)

        const int h = 0, i = 1;

        Debug.Log((h + i));

        // 조건문 if문

        if (AndOr == false)
        {
            Debug.Log("거짓입니다"); // 위의 bool AndOr = false 이므로 거짓입니다 출력
        }

        if (AndOr == true)
        {
            Debug.Log("참입니다"); // 위의 이유로 출력 생략
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

        // C# 문법 연습 (계산)

        Debug.Log("결과는->" + 5);
        Debug.Log("결과는->" + (5 + 10));
        Debug.Log("결과는->" + 5 + 10);

        // 공백 문법 연습 (white spese)

        Debug.Log("a \b b");

        // 아주 그냥 C언어 ㅎㄷㄷ-_-;
        // 가독성이 좋게 해야 함 BACK SPASE...

        // 따옴표 '' or "" 출력하기
        // \"을 사용합니다.

        Debug.Log("\"문서가 출력됨\" ^오^");
        Debug.Log("\'야야야야야야야얔ㅋㅋㅋ \'");

        //프로그래밍 할 때 Tab키를 사용합니다~~~~~
        /*
        
        Ex)

        UnityEngine.Debug.Log("\"문서가 출력됨\" ^오^");
            UnityEngine.Debug.Log("\"문서가 출력됨\" ^오^"); <- 들여쓰기 예시 (TAB 사용!)
        
         */

        int first = 10, second = 20, third = 30;

        Debug.Log(first + "," + second + "," + third + "\n" + "*/");

        //구구단 출력 연습

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
        string accdsa = "사람";

        Debug.Log($"{numbr}은{accdsa}입니다.");
        //외우면 껌 ㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋㅋ
        //유니티엔진의 기본요소!

        int harp = 10;
        harp = harp++; // harp = harp + 1
        Debug.Log(harp);

        int unharp = 10;
        unharp = unharp--;
        Debug.Log(unharp);
        /*
                int min = 2;
                int max = 5;

                Debug.Log(min < max); //true출력 (초과)
                Debug.Log(min > max); //false출력 (미만)
                Debug.Log(min <= max); //true출력 (이상)
                Debug.Log(min >= max); //false출력 (이하)

                Debug.Log(true || false); //true출력 (OR)
                Debug.Log(true && false); //false출력 (AND)
                Debug.Log(!false); //true 출력 (NOT)
        */
        int numbers1 = 3;
        int numbers2 = 5;
        bool TandF = false;

        TandF = numbers1 == 3 && numbers2 != 3;
        Debug.Log(TandF); // true출력

        int kor = 73, eng = 63, math = 90;
        int total = kor + eng + math;
        int ang = total / 3;

        Debug.Log($"당신의 총점은 : {total} 이고 당신의 점수평균은 {ang} 입니다.");

        for (int k = 1; k <= 3; k++)
        {

            switch (k)
            {
                case 1:
                    if (kor >= 90)
                        Debug.Log($"국어점수는{kor} 90점 이상이므로 A등급 입니다.");
                    else if (kor >= 80)
                        Debug.Log($"국어점수는{kor} 80점 이상이므로 B등급 입니다.");
                    else if (kor >= 70)
                        Debug.Log($"국어점수는{kor} 70점 이상이므로 C등급 입니다.");
                    else if (kor >= 60)
                        Debug.Log($"국어점수는{kor} 60점 이상이므로 D등급 입니다.");
                    else
                        Debug.Log($"국어점수는{kor} 60점 미만이므로 F등급 입니다.");
                    break;


                case 2:
                    if (eng >= 90)
                        Debug.Log($"영어점수는{eng} 90점 이상이므로 A등급 입니다.");
                    else if (eng >= 80)
                        Debug.Log($"영어점수는{eng} 80점 이상이므로 B등급 입니다.");
                    else if (eng >= 70)
                        Debug.Log($"영어점수는{eng} 70점 이상이므로 C등급 입니다.");
                    else if (eng >= 60)
                        Debug.Log($"영어점수는{eng} 60점 이상이므로 D등급 입니다.");
                    else
                        Debug.Log($"영어점수는{eng} 60점 미만이므로 F등급 입니다.");
                    break;

                case 3:
                    if (math >= 90)
                        Debug.Log($"국어점수는{math} 90점 이상이므로 A등급 입니다.");
                    else if (math >= 80)
                        Debug.Log($"국어점수는{math} 80점 이상이므로 B등급 입니다.");
                    else if (math >= 70)
                        Debug.Log($"국어점수는{math} 70점 이상이므로 C등급 입니다.");
                    else if (math >= 60)
                        Debug.Log($"국어점수는{math} 60점 이상이므로 D등급 입니다.");
                    else
                        Debug.Log($"국어점수는{math} 60점 미만이므로 F등급 입니다.");
                    break;


            }

        }

        // 반복 메소드
        void Update()
        {

        }
    }
}