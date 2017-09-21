using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	public string[] heros = new string[6];
	
	
	// Use this for initialization
	void Start () {

		heros[0] = "Batman";
		heros[1] = "Superman";
		heros[2] = "Supidaman";
		heros[3] = "Catwoman";
		heros[4] = "YourMom";
		heros[5] = "CaptainUnderPants";

		//print(heros[3]);
		for(int i=0; i<5; i++){
			print(heros[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
