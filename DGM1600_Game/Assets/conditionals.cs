using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals : MonoBehaviour {

	public string stopLight = "Red";

	void Start()
	{
		Main();
	}
	void Main(){
		
		if(stopLight == "Red"){
			print("STOP! The light is Red!");
	}
		else if(stopLight == "Yellow"){
			print("The Light is Yellow. SLOW DOWN!!!");
		}
		else if(stopLight == "Green"){
			print("Green Means GO!");
		}
		else{
			print("Are you sure you are at a Stop Light?!");
		}

	}
	


}
