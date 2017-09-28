using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string townCenter;

	// Use this for initialization
	void Start () {
		switch (townCenter){
			case "main":
				print("you are on main street dummy");
				break;
			case "state":
				print("you are on state street..... real helpful I know");
				break;
			case "blacksmith":
				print("the Blacksmith gives you a funny look. Most likely because of your clothes...");
				break;
			case "bakery":
				print("the smell alone guides you straight into the store. Before you know it you are halfway through a fresh doughnut");
				break;
			case "morgue":
				print("the smell of people rotting immediately makes you turn around");
				break;
			default:
				print("apparently you haven't even made it into the city.... lost much?");
				break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
