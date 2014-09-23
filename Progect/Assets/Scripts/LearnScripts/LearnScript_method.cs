using UnityEngine;
using System.Collections;

public class LearnScript_method : MonoBehaviour {

    public GameObject MyFish01;

    public int number1 = 2;
    public int number2 = 9;
    public int number3 = 11;

    public int MyBlood = 30;
    public int AnmBlood = 70;
	// Use this for initialization
	void Start () {

        //AddTwoNumbers(number1, number2);
        //AddTwoNumbers(number1, number3);
        //AddTwoNumbers(number2, number3);


        int answer = AddTwoNumbers(number1, number2) + AddTwoNumbers(number1, number3);
        //   24=         11                          +  13
        DisplayeResault(answer);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
           // AddTowNumber();
         //   Debug.Log(AddTowNumber2()+AddTowNumber2());
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
        }

        if (true/*用户按下M */)
        {
            AddTwoBloods(MyBlood, AnmBlood);
        }
	}

    public float num1, num2, num3;
    private float num4;

    float AddThreeNumber(float num1, float num2, float num3)
    {
        return this.num1 + this.num2 + this.num3;
       // return num1 + num2 + num3;
    }

    int AddTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }

    void AddTwoBloods(int myBlood, int anmBlood)
    {
        int myCurrentBlood = myBlood + anmBlood;
        Debug.Log(myCurrentBlood);
    }

    void DisplayeResault(int total)
    {
        Debug.Log("输出的结果是：  "+total);
    }



    //void AddTowNumber1()
    //{
    //    Debug.Log(number1 + number2);
    //}

    //int AddTowNumber2()
    //{
    //    return number1 + number2;
    //}

    
}
