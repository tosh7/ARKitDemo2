using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestViewController : MonoBehaviour {

	int num = 0;

	// Use this for initialization
	void Start () {
		if (num == 3 ){
			num = 4;
		}
		Debug.Log(num);
		print(num);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
