using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0224_study6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   //이진수를 정수로 변환하자
               Console.Write("2진수를 입력하세요.");
               string binaryInput = Console.ReadLine(); // 문자열 입력
               int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 > 10진수

               //정수를 이진수로 변환
               string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 > 2진수

               Console.WriteLine($"입력한 이진수 : {binaryOutput}");
               Console.WriteLine($"10진수로 변환 : {binaryInput}");
               Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");*/



            /*  //var를 사용하여 변수 선언
              var name = "Alice"; // 문자열로 추론
              var age = 25;//정수로 추론
              var isStudent = true;

              Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");*/




            /* int defaultInt = default; //기본값 : 0
             string defaulString = default; // 기본값 : null
             bool defaultBool = default; // 기본값 : false

             Console.WriteLine($"정수 기본값 : {defaultInt}");
             Console.WriteLine($"문자열 기본값 : {defaulString}");
             Console.WriteLine($"논리값 기본값 : {defaultBool}");*/




            /*int a = 1, b = 4;

            int sum = 0;
            sum = a + b; //산술 연산자 사용
            Console.WriteLine($"합 : {sum}");

            sum = a - b; //산술 연산자 사용
            Console.WriteLine($"빼기 : {sum}");

            sum = a * b; //산술 연산자 사용
            Console.WriteLine($"곱하기 : {sum}");

            sum = a / b; //산술 연산자 사용
            Console.WriteLine($"나누기 : {sum}");





            int c = 0, d = 0;

            c = 10;
            d = 3;
            sum = c % d;
            Console.WriteLine($"나머지 : {sum}");*/
            /*
                        int number = 7;

                        int sum = 0;

                        sum = number % 2; //0 나오면 짝수 1 홀수

                        Console.WriteLine($"짝수 홀수 판별 : {sum}" );*/





            /*   bool isEqual = false; //거짓 0

               int a = 5; int b = 4;

               //관계형 연산자
               isEqual = (a == b); //a랑 b랑 같니

               Console.WriteLine("같은가?" + isEqual);*/






            /*  // 단항 연산자
              int number = 5;
              bool flag = true;

              Console.WriteLine(+number);
              Console.WriteLine(-number);

              Console.WriteLine(!flag);


              int num = 10;
              int result = ~num;   //모든 비트 반전 : 1111 0101 결과 


              Console.WriteLine("원래 값 : " + num);
              Console.WriteLine("~ 연산자 적용 후: " + result);*/





            /* //캐스팅
             double pi = 3.14;
             int integerPi = (int)pi; // 실수형 > 정수형 변환

             Console.WriteLine(integerPi); //3

             int iKor = 90;
             int iEng = 75;
             int iMath = 58;

             int sum = 0;
             float average = 0.0f;

             sum = iKor + iEng + iMath;

             average = (float)sum / 3; // 평균

             Console.WriteLine("총점 : " + sum);
             Console.WriteLine( "평균 : " + average);*/





            /*  int a = 10, b = 3;

              Console.WriteLine(a+b);
              Console.WriteLine(a-b);
              Console.WriteLine(a*b);
              Console.WriteLine(a/b);
              Console.WriteLine(a%b);*/






            /*            //문자열 연결 연산자

                        string firstName = "Alice";
                        string lastName = "Smith";

                        Console.WriteLine(firstName + " " + lastName); //출력*/





            /* 
             
             int a = 10;
             a += 5; // a =  a  + 5;

             Console.WriteLine(a);

             a -= 5;
             Console.WriteLine(a);

             a *= 5;
             Console.WriteLine(a);

             a /= 2;
             Console.WriteLine(a);

             a %= 4;
             Console.WriteLine(a);


            Console.WriteLine("점수를 입력해주세요");

            Console.WriteLine("국어");
            string krInput = Console.ReadLine();
            int kr = int.Parse(krInput);
            Console.WriteLine("영어");
            string enInput = Console.ReadLine();
            int en = int.Parse(enInput);
            Console.WriteLine("수학");
            string maInput = Console.ReadLine();
            int ma = int.Parse(maInput);

            int sum = kr + en + ma;
            float avg = (float)sum / 3;
            Console.WriteLine($"총합 점수 : {sum}");
            Console.WriteLine($"평균 점수 : {avg.ToString("F2")}");

            Console.WriteLine("숫자를 입력해주세요");
            string input = Console.ReadLine();
            int ainput = int.Parse(input);

            int binput = ~ainput;
            Console.WriteLine($"입력값 : {ainput} ");
            Console.WriteLine($"연산 후 : {binput} ");*/


            /*      // 전위 ++b , 후위 b++
                 int b = 4;
                 ++b; // 전위증가
                 Console.WriteLine(b); //출력 ; 5
                Console.WriteLine(++b);


                int c = 4;
                Console.WriteLine(c++); // 후위증가는  여기에 적용X 다음 라인에서만 적용
                Console.WriteLine(c);
                Console.WriteLine(c++);
                Console.WriteLine(c++);*/


            //관계형 연산자
            //두 값을 비교하여 관계를 평가한다.
            // == 같다. != 같지 않다 a<b  c>d  <=  =>

            /*int x = 5, y = 10;

            Console.WriteLine(x == y); //f
            Console.WriteLine(x != y); //t
            Console.WriteLine(x < y); //t
            Console.WriteLine(x > y); //f
            Console.WriteLine(x <= y); //t
            Console.WriteLine(x >= y); //f
*/


            /* //논리 연산자

             bool a = true;
             bool b = false;

             Console.WriteLine(a && b); //둘 다 t값이어야 통과가능
             //AND 1 : 1 t 
             //AND 1 : 0 f 
             //AND 0 : 1 f 
             //AND 0 : 0 f 

             Console.WriteLine(a || b); //둘 다 t값이어야 통과가능
             //AND 1 : 1 t 
             //AND 1 : 0 t 
             //AND 0 : 1 t
             //AND 0 : 0 f 

             bool a = false;
             bool b = false;

             b = !a;

             Console.WriteLine(b); //true*/



            /*
                        //비트연산자

                        int x = 5; // 0101
                        int y = 3; // 0011

                        Console.WriteLine(x & y); //AND : 1(0001)
                        Console.WriteLine(x | y); //OR : 7(0001)
                        Console.WriteLine(x ^ y); //XOR : 6(0110) 숫자가 같으면 0이됨 미틴것
                        Console.WriteLine(~x); //NOT : -6


                        int value = 4; //0100
                        Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
                        Console.WriteLine(value >> 1); //오른쪽으로 이동 : 2 (0010)





                        int a =10, b =20;

                        int max;

                        max = (a > b) ? a : b; //삼항 연산자

                        Console.WriteLine(max);

                        // (비교) ? 참 : 거짓;
                        // ? 가 앞에 것이 참이면? a가 max가 되는 것이고 거짓이면? b가 max가 되는 것이다!*/





            /*             //비트연산자

                                  int x = 5; // 0101
                                  int y = 3; // 0011

                                  Console.WriteLine(x & y); //AND : 1(0001)
                                  Console.WriteLine(x | y); //OR : 7(0001)
                                  Console.WriteLine(x ^ y); //XOR : 6(0110) 숫자가 같으면 0이됨 미틴것
                                  Console.WriteLine(~x); //NOT : -6


                                  int value = 4; //0100
                                  Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
                                  Console.WriteLine(value >> 1); //오른쪽으로 이동 : 2 (0010)





                                  int a =10, b =20;

                                  int max;

                                  max = (a > b) ? a : b; //삼항 연산자

                                  Console.WriteLine(max);

                                  // (비교) ? 참 : 거짓;
                                  // ? 가 앞에 것이 참이면? a가 max가 되는 것이고 거짓이면? b가 max가 되는 것이다!*/


            /*   int key = 1;

               string str;
               str = (key == 2) ? "문이열렸습니다." : "문을 못열었습니다.";

               Console.WriteLine(str);


               ///곱셈

               int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선

               int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저계산

               Console.WriteLine(adjustedResult);
   */




            /*  //

              Console.WriteLine("문을 열기 위해 뭐가 필요하지?");
              string enInput = Console.ReadLine();

              if (enInput == "열쇠")
              {
                  Console.WriteLine("문이 열렸습니다");
              }
              else
              {
                  Console.WriteLine("문이 열리겠냐");
              }


              int score = 85;

              if (score >= 90)
              {
                  Console.WriteLine("A 학점");
              }
              else
              {
                  Console.WriteLine("B 학점");
              }


              if (true)
              {
                  Console.WriteLine("진실");
              }
              else
              {
                  Console.WriteLine("거짓");
              }

  */
            /*
                        int score = 60;

                        if (score >= 90)
                        {
                            Console.WriteLine("자네는 A일세");
                        }
                        else if (score >=80)
                        {
                            Console.WriteLine("자네는 B일세");
                        }
                        else if (score >= 70)
                        {
                            Console.WriteLine("자네는 C일세");
                        }
                        else
                        {
                            Console.WriteLine("자네는 F일세");
                        }

                        */




            /*      //가지고 있는 소지금을 입력하세요 :

                  Console.WriteLine("가지고 있는 소지금을 입력하세요.");
                  int money = int.Parse(Console.ReadLine());

                  string ww;
                  int kk = 0;

                  if (money <= 100) 
                  {
                      ww = "무한의 대검";
                      kk = 1;
                  }
                  else if (money <= 200)
                  {
                      ww = "카타나";
                      kk = 2;
                  }
                  else if (money <= 300)
                  {
                      ww = "진은검";
                      kk = 3;
                  }
                  else if (money <= 400)
                  {
                      ww = "집판검";
                      kk = 4;
                  }
                  else if (money <= 500)
                  {
                      ww = "엑스칼리버";
                      kk = 5;
                  }
                  else if (money <= 600)
                  {
                      ww = "유령검";
                      kk = 6;
                  }
                  else
                  {
                      ww = "전설의검";
                      kk = 7;
                  }

                  Console.WriteLine($"{ww}을(를) 얻었다!");

                  Console.WriteLine(" ");
                  Console.WriteLine(" ");
                  Console.WriteLine("캐릭터 이름 : 복분자");
                  Console.WriteLine("현재 무기 : " + ww);

                  kk += 100;
                  Console.WriteLine("공격력 : " + kk);*/





            Console.WriteLine("세 정수를 입력해주세요.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int num0 = 0;

            if (num1 > num2)
            { num0 = num1; }
            else if (num1 < num2)
            { num0 = num2; }

            if (num0 > num3){}
            else if(num0 < num3)
            { num0 = num3; }

            Console.WriteLine("최대값 : " + num0);



            Console.WriteLine(" ");
            Console.WriteLine("점수를 입력해주세요.");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("자네는 A일세");}
            else if (score >= 80)
            {
                Console.WriteLine("자네는 B일세");}
            else if (score >= 70)
            {
                Console.WriteLine("자네는 C일세");}
            else if (score >= 60)
            {
                Console.WriteLine("자네는 D일세"); }
            else
            {
                Console.WriteLine("자네는 F일세");}



            Console.WriteLine(" ");
            Console.WriteLine("두 숫자를 입력해주세요.");
            int num01 = int.Parse(Console.ReadLine());
            int num02 = int.Parse(Console.ReadLine());

            Console.WriteLine("적용할 연산자를 +, -, *, / 골라주세요.");
            string p = Console.ReadLine();

            int a = 0;

            if (p == "+") { a = num01 + num02; }
            else if (p == "-") { a = num01 - num02; }
            else if (p == "*") { a = num01 * num02; }
            else if (p == "/") { a = num01 / num02; }
            else if (num02 == 0) {Console.WriteLine("오류!");
            } 

            Console.WriteLine($"결과; {a}");









        }
    }
}

