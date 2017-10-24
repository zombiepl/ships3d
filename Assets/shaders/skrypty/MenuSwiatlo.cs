using UnityEngine;
using System.Collections;

public class MenuSwiatlo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.RotateAroundLocal(Vector3.up,0.03f);
	}
}
