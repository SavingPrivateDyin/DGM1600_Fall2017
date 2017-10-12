using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		List<BadGuy> badguys = new List<BadGuy>();

		badguys.Add( new BadGuy("Snoke", 1000));
		badguys.Add( new BadGuy("Magneto", 50));
		badguys.Add( new BadGuy("Your Mom", -2));

		badguys.Sort();

		foreach(BadGuy guy in badguys){
			print (guy.name + " " + guy.power);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
