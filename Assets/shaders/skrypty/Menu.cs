using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 void OnGUI() {
		GUI.BeginGroup (new Rect (Screen.width/2-150, Screen.height /2 , 300, 200));//Screen.height / 2 - 300
		GUI.Box(new Rect(0, 0, 300, 200),"");

		if (GUI.Button (new Rect (90,10,120,30), "GRAJ"))
		{Application.LoadLevel (2);
				}	
		if (GUI.Button (new Rect (90,60,120,30), "WYJSCIE"))
		{Application.Quit();}
		
		
		GUI.EndGroup();
		

    }
	
}
