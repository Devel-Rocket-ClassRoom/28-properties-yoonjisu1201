using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Student[] student =
{
    new Student("김철수") {KoreanScore = 85, EnglishScore = 90, MathScore = 95},
    new Student("이영희") {KoreanScore = 75, EnglishScore = 80, MathScore = 70},
    new Student("박민수") {KoreanScore = 110, EnglishScore = 120, MathScore = -10}
};

student[0].ShowInfo();
student[1].ShowInfo();
student[2].ShowInfo();



class Student
{
    public string Name { get; }

    private int _koreanScore;
    private int _englishScore;
    private int _mathScore;

    public int KoreanScore
    {
        get { return _koreanScore; }
        set
        {
            _koreanScore = Math.Clamp(value, 0, 100);
        }
    }

    public int EnglishScore
    {
        get { return _englishScore; }
        set
        {
            _englishScore = Math.Clamp(value, 0, 100);
        }
    }

    public int MathScore
    {
        get { return _mathScore; }
        set
        {
            _mathScore = Math.Clamp(value, 0, 100);
        }
    }
    public int TotalScore => _koreanScore + _englishScore + _mathScore;
    public double Average => TotalScore / 3.0;
    public string Grade
    {
        get
        {
            if (Average >= 90)
            {
                return "A";
            }
            else if (Average >= 80)
            {
                return "B";
            }
            else if (Average >= 70)
            {
                return "C";
            }
            else if (Average >= 60)
            {
                return "D";
            }
            else { return "F"; }
        }
    }

    public Student(string name) => Name = name;
  

    public void ShowInfo()
    {
        Console.WriteLine($"=== 성적표: {Name} ===");
        Console.WriteLine($"국어: {_koreanScore}, 영어: {_englishScore}, 수학: {_mathScore}");
        Console.WriteLine($"총점: {TotalScore}");
        Console.WriteLine($"평균: {Average:F2}");
        Console.WriteLine($"학점: {Grade}");
        Console.WriteLine();
    }


}
