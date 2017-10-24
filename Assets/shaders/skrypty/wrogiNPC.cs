using UnityEngine;
using System.Collections;

public class wrogiNPC : MonoBehaviour {//obserwacja gracza

public float speed;
public static int wrogZniszczony;	
	
	void Start () {
		speed = Random.Range(0.07f,0.3f);
		 
	}
    void Update() {
		transform.Translate(Vector3.forward *speed,Space.Self);
}

void OnCollisionEnter(Collision collision) {

			 if (collision.gameObject.tag !="Terrain") {//.tag == "pociskPref"
			 Debug.Log("trafiony statek");
	//	Quaternion rot = Quaternion.FromToRotation (Vector3.up,Vector3.up);
	//	Vector3 pos = transform.position;
       			
        Destroy(gameObject);
		rozgrywka.iloscWrogow=rozgrywka.iloscWrogow-1;
    }
}



}
