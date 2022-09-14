using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public QuizData quizData;

    public string[] wrongQuiz;

    public string trueQuiz;

    public string[] quizList;

    public Button button;

    void Start()
    {
        QuizListSet();

        WrongShuffleArray();

        for (int i = 1; i < quizData.answerCount; i++)
            quizList[i] = wrongQuiz[i];

    }

    private void QuizListSet()
    {
        wrongQuiz = new string[quizData.wrongAnswer.Length];

        for (int i = 0; i < wrongQuiz.Length; i++)
        {
            wrongQuiz[i] = quizData.wrongAnswer[i];
        }

        trueQuiz = quizData.trueAnswer;

        quizList = new string[wrongQuiz.Length];

        quizList[0] = trueQuiz;
    }

    private void WrongShuffleArray()
    {
        int random1, random2;
        string temp;

        for (int i = 0; i < wrongQuiz.Length; ++i)
        {
            random1 = Random.Range(0, wrongQuiz.Length);
            random2 = Random.Range(0, wrongQuiz.Length);

            temp = wrongQuiz[random1];
            wrongQuiz[random1] = wrongQuiz[random2];
            wrongQuiz[random2] = temp;
        }
    }

    private void QuizShuffleArray()
    {
        int random1, random2;
        string temp;

        for (int i = 0; i < quizList.Length; ++i)
        {
            random1 = Random.Range(0, quizList.Length);
            random2 = Random.Range(0, quizList.Length);

            temp = quizList[random1];
            quizList[random1] = quizList[random2];
            quizList[random2] = temp;
        }
    }
}
