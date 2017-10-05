using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VoidFun : MonoBehaviour {
	

	public int ranNum = 0;
	public int fate;
	// Use this for initialization
	void Start () {
		fate = Random.Range(1,3);
		ranNum = fate;
		DeathStar(ranNum);
		DeathStar(ranNum);
		DeathStar(ranNum);
		DeathStar(ranNum);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent) {
		if(vent == 1){
			print("Porkins Missed His Shot");
		}
		else if(vent == 2){
			print("Red Leader Tries Run But is Unsuccessful");
		}
		else if(vent == 3){
			print("Luke Listens to Obi Wan's creepy whispers and uses the Force to destroy the DeathStar!");
		}
		else{
			print("well I guess the Darkside Wins");
		}
	}
}
