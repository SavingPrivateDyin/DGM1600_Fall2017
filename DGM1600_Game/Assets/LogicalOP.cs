using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOP : MonoBehaviour {
	public string luke ="Jedi";
	public string vader = "Sith";
	// Use this for initialization
	public bool leia = true;
	public string darkSide = "we have cookies";
	public string lightSide = "Obi Wan";
	void Start () {
		// if (luke == "Jedi" && vader == "Sith"){
		// 	print("luke, I'm your father. Noooooooo");
		// }
		// else if(luke == "jawa" && vader == "Sith"){
		// 	print("whodeedee");
		// }
		// else 
		// 	print("screw you emperor palpatine!");

		// if(leia){
		// 	print("No, there is another");
		// }
		// else if(!leia){
		// 	print("Whew, dodged a bullet on that one");
		// }
		// else{
		// 	print("Han fired first!");
		// }
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar"){
			print("All is balanced");
		}
		if(lightSide == "jar jar" || darkSide == "we have cookies"){
			print("WE HAVE COOKIES!");
		}
		else
			print("you must be a gray jedi");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
