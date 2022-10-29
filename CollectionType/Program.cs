// 1차원 Array 생성 방법
string[] players = new string[10];
string[] regions = { "서울", "경기", "부산" };

// 2차원 Array 생성 방법
string[,] deptInfo = { { "홍길동", "인프라팀" }, { "홀리오팍", "법무팀" }, { "첸진", "무역팀" } };

// 3차원 Array 생성 방법
string[,,] cube;

// 1차원 배열 출력 String.Join()
Console.WriteLine("players Array는 1차원이며 10개의 원소를 가지도록 초기화됨");
Console.WriteLine(String.Format("Array Length : {0}", players.Length.ToString()));
Console.WriteLine(String.Join(", ", players));

// 2차원 Array 출력
for (int i=0; i < deptInfo.Length; i++)
{
    Console.WriteLine(String.Join(", ", deptInfo.GetValue(i)));
}
