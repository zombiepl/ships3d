using UnityEngine;
using System.Collections;

public class bulgarskiPociskNPC : MonoBehaviour {

public static Vector3 oldPos;
public Vector3 kierStrzalu;


	void Start () {
	
	oldPos=transform.position;

	}
	void Update () {
	if (bronNPC.strzal  == true)	
		
		{
			transform.Translate(Vector3.up *(-3),Space.Self);
			Destroy(gameObject,25.0f);//zaprogramowany czas zycia rakiety
		}

	}

	 void OnCollisionEnter(Collision collision) {
		
	 if (collision.gameObject.tag == "Player") {
            Debug.Log("trafil gracza");
		Quaternion rot = Quaternion.FromToRotation (Vector3.up,Vector3.up);
		Vector3 pos = transform.position;
        Instantiate(Resources.Load("wybuch2"), pos, rot);
        Destroy(gameObject);		
			
      }
		
	 if (collision.gameObject.tag == "Terrain") {
            Debug.Log("trafil w ziemie");			
		Quaternion rot = Quaternion.FromToRotation (Vector3.up,Vector3.up);
		Vector3 pos = transform.position;
        Instantiate(Resources.Load("wybuch2"), pos, rot);
        Destroy(gameObject);		
		
      }		
		

		if (collision.gameObject.tag == "Woda") {
            Debug.Log("trafil w wode");
			   Destroy(gameObject);	
    }
				if (collision.gameObject.tag == "koniecSwiata") {
            Debug.Log("trafil w koniec swiata");
			   Destroy(gameObject);	
    }
	
	}}
	

	
	
	

