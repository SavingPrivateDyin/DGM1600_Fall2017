using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
	

	public void DoStuff(){
		print("I'm doing the good stuff! ;)");
	}

	public string DoStuff2(){
		string stuff = "I'm doing stuff better";

		return stuff;
	}
	public int AddNumbers(int num1, int num2){
		
		int result = num1 + num2;

		return result;
	}

	

	public void Start(){
		DoStuff();
		
		string pancakes = DoStuff2();
		print(pancakes);
	}
}

