using UnityEngine;
using System.Collections;

public class TestScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("");
	}
	
	// Update is called once per frame
    int _count = 0;
	void Update () {
        Debug.Log("_count: " + _count++);
	}
}
