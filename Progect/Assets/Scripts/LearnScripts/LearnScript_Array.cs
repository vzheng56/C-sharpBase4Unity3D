using UnityEngine;
using System.Collections;

public class LearnScript_Array : MonoBehaviour {

    public string[] MyStringArray;
    public string[] WoDeStringShuZu;

    void Start()
    {
        WoDeStringShuZu=new string[10];
        //赋值和使用

        MyStringArray[0] = "H"; //完成赋值
        MyStringArray[1] = "E";
        MyStringArray[2] = "L";

        Debug.Log(MyStringArray[0]); //使用： 下标访问方式
        Debug.Log(MyStringArray[1]); //使用： 下标访问方式
        Debug.Log(MyStringArray[2]); //使用： 下标访问方式
        Debug.Log(MyStringArray[3]); //使用： 下标访问方式
    }
}
