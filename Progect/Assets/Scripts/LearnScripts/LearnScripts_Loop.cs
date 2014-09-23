using UnityEngine;
using System.Collections;

public class LearnScripts_Loop : MonoBehaviour {

    public int[] MyIntArray;

	void Start () {

        MyIntArray=new int [100];

        for (int i = 0; i < 100; ++i)
        {
            MyIntArray[i] = i+1;
         //   Debug.Log(MyIntArray[i]);
        }
        int result=0;
        //i++  等同于  i=i+1  等同于  i+=1 
        //for (int i = 0; i < MyIntArray.Length; ++i)
        //{
        //    result = result + MyIntArray[i];
        //}

        result = 0;
        //foreach (int temp in MyIntArray)
        //{
        //    result = result + temp;
        //}
        bool loopBool=true;

        int j = 0;
        while(j<MyIntArray.Length)
        {
            result += MyIntArray[j];
            j++;
        }
        Debug.Log(j);

        Debug.Log(result);
	}


    // 定义一个方法  返回 1+2+3+。。+N
    int AddNValue(int N)
    { 
        int result=0;

        return result;
    }
}
