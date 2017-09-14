using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

	public int valueOne;
	public int valueTwo;
	public int valueThree;
	public int valueFour;
	private int result;


	// Use this for initialization
	void Start () {
		DoMath();
		DoMath2();

	}
	
	void DoMath(){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);
		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);
		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);
	}
	void DoMath2(){
		result = valueOne + valueTwo + valueThree + valueFour;
		print(valueOne + " + " + valueTwo + " + " +  valueThree + " + " + valueFour + " = " + result);
		result = valueOne / valueThree - valueFour;
		print(valueOne + " / " + valueThree + " - " + valueFour + " = " + result);
		result = valueTwo * valueThree / valueFour;
		print(valueTwo + " * " + valueThree + " / " + valueFour + " = " + result);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
