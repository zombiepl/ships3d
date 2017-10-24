using UnityEngine;
using System.Collections;

public class most : MonoBehaviour {
public static bool wygrales;
	// Use this for initialization
	void Start () {
	wygrales = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	
	
 void OnCollisionEnter(Collision collision) {
		
	 if (collision.gameObject.tag == "goraMostu") {
            Debug.Log("kolija z goramostu");
wygrales = true;	
			
      }
	
	
	
}}
