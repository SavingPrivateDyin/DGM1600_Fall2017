using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {
	public int bottles = 0;
	// Use this for initialization
	void Start () {
		while(bottles < 100){
			print(bottles + " bottles of beer on the wall");
			bottles++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
