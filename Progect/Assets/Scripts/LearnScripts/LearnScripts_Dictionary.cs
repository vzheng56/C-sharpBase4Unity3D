using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LearnScripts_Dictionary : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Dictionary<int, string> myClassDictionary = new Dictionary<int, string>()
        {
            {20144701,"田沣"},{20144702,"刘骏"},{20144703,"王凯"}
        };

        myClassDictionary[20144706] = "邓杰文";

        Debug.Log("学号为 20144701 的同学是：  " + myClassDictionary[20144701]);
        Debug.Log("学号为 20144702 的同学是：  " + myClassDictionary[20144702]);
        Debug.Log("学号为 20144703 的同学是：  " + myClassDictionary[20144703]);

        Debug.Log("学生的总数：  "+myClassDictionary.Count);

        List<string> myGunList = new List<string>() { "来福枪", "沙鹰", "大炮" };

        Debug.Log("我喜欢的武器总共有： " + myGunList.Count + " 个");
        myGunList.Add("狙击步枪");
	}
}
