using UnityEngine;
using System.Collections;
//引用命名空间
using System.Collections.Generic;

public class LearnScripts_List : MonoBehaviour {

    //列表的定义
    List<int> myNumberList;

	// Use this for initialization
	void Start () {

        //列表的初始化
        myNumberList = new List<int>();

        //定义列表 并初始化
        List<string> myGunList = new List<string>();

        myGunList.Add("来福枪");
        myGunList.Add("沙鹰");
        myGunList.Add("大炮");

        Debug.Log("我喜欢的武器总共有： "+myGunList.Count+" 个");
        myGunList.Add("狙击步枪");

        Debug.Log("武器的名字 索引第一个是： " + myGunList[0]);
        Debug.Log("武器的名字 索引第二个是： " + myGunList[1]);
        Debug.Log("武器的名字 索引第三个是： " + myGunList[2]);
        Debug.Log("武器的名字 索引第四个是： " + myGunList[3]);
	}
}
