using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArithmeticOperations : MonoBehaviour
{
    public Text firstNum;
    public Text op;
    public Text secondNum;
    public Text result;
    public Text evaluation;
    public InputField resultField;
    int num1;
    int num2;
    int opNumber;
    int correctAnswer;

    // Start is called before the first frame update
    private void Start()
    {
        NumCalc();
        OpCalc();
    }

    private void OpCalc() //Decides what the arithmetic operator is.
    {
        opNumber = Random.Range(1, 5);
        switch (opNumber)
        {
            case 1:
                op.text = "+";
                correctAnswer = num1 + num2;
                break;
            case 2:
                op.text = "-";
                correctAnswer = num1 - num2;
                break;
            case 3:
                op.text = "*";
                correctAnswer = num1 * num2;
                break;
            case 4:
                op.text = "/";
                correctAnswer = num1 / num2;
                break;
            default:
                break;
        }
    }

    private void NumCalc()
    {
        num1 = Random.Range(1, 16);
        firstNum.text = num1 + "";
        num2 = Random.Range(1, 16);
        secondNum.text = num2 + "";

    }

    public void CheckAnswer()
    {
        if (correctAnswer.ToString() == result.text)
        {
            evaluation.text = "Correct!";
        }
        else
        {
            evaluation.text = "False!\nTry again.";

        }
    }
    public void NewQuestion()
    {
        resultField.text = "";
        NumCalc();
        OpCalc();
        evaluation.text = "";
    }

}
