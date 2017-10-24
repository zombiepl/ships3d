using UnityEngine;
using System.Collections;

public class intro : MonoBehaviour {
float czas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 czas=Time.time;
		Debug.Log(czas);
		if (Time.time >= 6)
			Application.LoadLevel(1);
	}
}
