namespace Class1th;
class Program
{
    static void Main(string[] args)
    //static void Main(string[] args)
    //프로그램의 진입점 역할을 수행하는 함수입니다.

    // Main() 프로젝트 내에서 단 하나만 존재해야 합니다.
    {
        
        #region 자료형
        /*데이터를 저장하기 위해 데이터의 형태를 정해주는 것입니다.

        자료형은 각가가의 자료형마다 크기각 정해져 있으면, 자료형의 크기는
        바이트 단위로 이루어져 있습니다.*/

        #endregion

        #region 변수
        //데이터를 저장할 수 있는 메모리 공간을 생성하는 것입니다.

        bool boolean = true;   //bool : 1 byte

        char character = 'A'; //char : 1 byte

        short shortData;// shrot : 2 byte

        int interger = 100;   // int   : 4 byte

        float health = 3.15f;   // float : 4 byte

        double attack = 3.44444444444444444;  // double : 8 byte

        //변수를 생성하게 되면 변수는 메모리 공간을 가지게 됩니다.
        ////변수의 메모리 공간은 프로그램이 실행될 때마다 바뀌며, 여러개의
        ////변수가 있을 때 서로 고유의 메모리 공간을 가지고 있습니다.
        boolean = true;
        character = 'B';
        interger = 50;
        health = 3.65f;
        attack = 3.55555555555555555555555;
        ////메모리 공간을 해당 메모리에 저장된 값을 참조할 수 있으며,
        ////변수를 생성하기 위해 메모리 공간의 크기를 지정해주는 자료형을 먼저 선언해주어야 합니다.

        ////Console.WriteLine(); : 특정한 문자열을 출력하는 함수입니다.
        Console.WriteLine("boolean 바뀐 변수의 값" + boolean);
        Console.WriteLine("character 바뀐 변수의 값" + character);
        Console.WriteLine("interger 바뀐 변수의 값" + interger);
        Console.WriteLine("health 바뀐 변수의 값" + health);
        Console.WriteLine("attack 바뀐 변수의 값" + attack);

        // 변수는 프로그램이 실행되는 동안 값을 바꿀 수 있으며,
        // 원래 저장되어 있는 값은 새로 저장되는 값에 의해 지워집니다.

        #endregion

        #region 변수의 이름 규칙

        // 1. 변수의 이름은 중복이 허용되지 않습니다.
        //ex) int data:
        //ex) int data;

        // 2. 변수의 이름으로 대소문자를 구분합니다.
        int value;
        int VALUE;

        // 3. 변수의 이름으로 예약어를 사용할 수 없습니다.
        //ex) int int;

        // 4. 변수의 이름으로 특수 기호는 "_"만 허용합니다.
        //int tabel = 200;

        // 5. 변수의 이름에 공백이 포함될 수 없습니다.
        //ex) int count down = 5;

        // 6. 변수의 이름은 숫자로 시작할 수 없으며, 컴파일하는
        //    동안 어휘 분서겡서 역 추적을 피할 수 있으므로,
        //    시작 위치에서만 숫자를 사용할 수 없습니다.

        //ex) int 1th;
        //ex) int class2th;

        #endregion
    }
}
// int      정수형
// float    실수형
// string   문자
// bool     true false
// ctrl k + c 전체 주석 ctrl k + u 전체 주석 해제
// ctrl Alt + L = Solutin 키기