using UnityEngine;
using System.Collections;

public class LearnScripts_Choose : MonoBehaviour {

    public enum WeekDay 
    {
        SunDay=0,
        MonDay,
        TuesDay,
        
    }

    public WeekDay myWeekDay = WeekDay.MonDay;

    int _switchValue = 1;
    string _buttonName = "";
	// Use this for initialization
	void Start () {

        switch (_buttonName)
        {
            case "":
                Debug.Log("Value:  " + _switchValue);
                break;
            case "11":
                    Debug.Log("Value111:  " + _switchValue);
                    Debug.Log("Value222:  " + _switchValue);
                    break;
            case "22":
                    Debug.Log("Value:   " + _switchValue);
                    break;
        }


        bool theBearMadeBigPottyInTheWoods = true;
        int temperrature = 40;

        if (temperrature >= 35 && theBearMadeBigPottyInTheWoods&&temperrature<20)
        {
            //  Debug.Log("两个变量判断都是真的");
        }
        else if (temperrature < 10) 
        { 
        }
        else if (temperrature < 5)
        { }
        else
        { }

        if (temperrature >= 35 || theBearMadeBigPottyInTheWoods)
        {
          //  Debug.Log("以上两种情况只有一个是真的");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Move Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Move Right!");
        }
	}
}
