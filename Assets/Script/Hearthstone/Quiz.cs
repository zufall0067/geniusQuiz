using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public QuizData quizData;

    public string[] wrongQuiz;

    public string trueQuiz;

    public string[] QuizList;
    
    void Start()
    {
        wrongQuiz = new string[quizData.wrongAnswer.Length];
        
        for(int i = 0; i < wrongQuiz.Length; i++)
        {
            wrongQuiz[i] = quizData.wrongAnswer[i];
        }

        trueQuiz = quizData.trueAnswer;

        QuizList = new string[wrongQuiz.Length + 1];
    }

    void Update()
    {
        
    }
}
