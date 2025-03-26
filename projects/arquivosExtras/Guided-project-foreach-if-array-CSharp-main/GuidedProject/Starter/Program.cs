using System;

/*
Você inicializa variáveis e cria as matrizes que servem como fonte de dados para o aplicativo. 
Você tem matrizes que fornecem as notas dos alunos, bem como uma matriz que fornece os nomes dos alunos. 
Você também tem uma matriz independente de aluno chamada studentScores 
que pode ser usada para manter as notas de qualquer aluno quando chegar a hora de calcular as notas.
*/
// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Students names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

/*
Você tem uma instrução Console.WriteLine() 
que escreve os rótulos de coluna do seu relatório de notas no console.
*/
// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");


/*
Você tem um loop externo foreach que é iterado por meio da matriz studentNames, 
fornecendo um bloco de código que se repete para cada aluno.
*/
foreach (string name in studentNames)
{
    
    string currentStudent = name;

    /*
    Você tem uma instrução if para avaliar o nome do aluno atual, 
    por exemplo if (currentStudent == "Sophia"). 
    Quando a expressão é avaliada como true, 
    você atribui a matriz de notas do aluno à matriz independente do aluno, 
    por exemplo: studentScores = sophiaScores;
    */
    // assign Sophia's scores to the studentScores array
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    // assign Andrew's scores to the studentScores array
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    // assign Emma's scores to the studentScores array
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    // assign Logan's scores to the studentScores array
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    /*
    Você declara as duas variáveis necessárias para calcular as notas dos alunos. 
    A primeira variável, sumAssignmentScores, é usada para calcular a soma das notas de tarefa. 
    A segunda variável, currentStudentGrade, é usada para calcular a nota numérica final. 
    Inicialize as variáveis com um valor de 0.
    */
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;
    // initialize/reset the calculated average of exam + extra credit scores    
    decimal currentStudentGrade = 0;


    /*
    Você tem um loop foreach 
    que é iterado por meio de studentScores 
    para calcular o valor de sumAssignmentScores.
    */
    foreach (int score in studentScores)
    {
        //add the exam score to the sum
        sumAssignmentScores += score;
    }

    /*
    Você calcula currentStudentGrade dividindo sumAssignmentScores pelo número de tarefas no livro de notas. 
    O número de tarefas que valem nota é mantido em uma variável chamada currentAssignments.
    */
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    /*
    Você tem um constructo if-elseif-else que atribui notas em letra com base no valor de currentStudentGrade.
    */
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    /*
    Você tem uma instrução Console.WriteLine() 
    que grava nomes de alunos e notas no console para concluir o relatório de notas
    */
    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
