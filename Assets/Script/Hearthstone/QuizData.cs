using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quiz Data", menuName = "Scriptable Object/HearthstoneQuiz", order = 2)]
public class QuizData : ScriptableObject
{
    public string quizName;

    public string question;

    public string[] wrongAnswer;
    public string trueAnswer;

    public Sprite questionImage;

    public int answerCount;
}
