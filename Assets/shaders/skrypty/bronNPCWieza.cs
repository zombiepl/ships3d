using UnityEngine;
using System.Collections;

public class bronNPCWieza : MonoBehaviour {
	public GameObject statekGracza;
	float dist;
	public static bool strzal;
	float reloadTime = 4;
	float timer = 0;
	void Start () {
 statekGracza = GameObject.Find("statek2");
		
	strzal = false;
	}
	
	
 //   public Transform other=gameObject.tag="Player";
	
    void Update() {
        if (statekGracza) {
            dist = Vector3.Distance(statekGracza.transform.position, transform.position);
			transform.LookAt(statekGracza.transform.position);
       //     print("odleglosc od gracza: " + dist);
        }
		
		if (dist<=90f){

		strzal = true;	
	
			}
    }
}
