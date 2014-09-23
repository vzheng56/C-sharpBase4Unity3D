/*
 * 本脚本完成了基本的用户的变量的定义
 * 主要知识点包括：  
 * 1. 变量的定义
 * 2. 变量的类型
 * 3. 变量的使用——存储数据
 * 4. 公共变量在Unity属性栏里面相当于属性
 * */
using UnityEngine;
using System.Collections;

public class LearnScript_Value : MonoBehaviour {

    private int MyIntValue = 20;

    public int nmber1 = 2;
    public float number2 = 4.7f;
    public double number3=4.7d;

    public string someWords = "Now is the time";
    public bool checkThisOut = true;


    public string Block1 = "Block 1 Text";
    public string Block5 = "Block 5 Text";

    //public float struct

   // public Color MyColorValue;
	// Use this for initialization
    void Start()
    {
        Debug.Log(Block1);

        string Block2 = "Block 2 Text";
        Debug.Log(Block2);

        {
            string Block3 = "Block 3 Text";
            Debug.Log(Block3);
        }

    }
    void MyMethod()
    {
        string Block3 = "abc";
        Debug.Log(Block3);
 
    }
	// Update is called once per frame
	void Update () {

	}
}
