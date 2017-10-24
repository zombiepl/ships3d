using UnityEngine;
using System.Collections;

public class odleglosc : MonoBehaviour {
public Transform odleglos1;
public Transform odleglos2;
float odleg;	
	// Use this for initialization
	void Start () {
	odleg=0;
	}
	
	// Update is called once per frame
	void Update () {
	odleg = Vector3.Distance (odleglos1.position,odleglos2.position);
		Debug.Log(odleg);
	}
}
