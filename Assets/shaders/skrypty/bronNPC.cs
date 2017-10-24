using UnityEngine;
using System.Collections;

public class bronNPC : MonoBehaviour {
	public GameObject statekGracza;
	float dist;
	public static bool strzal;

	void Start () {
 statekGracza = GameObject.Find("statek2");
		
	strzal = false;
	}
	
	

	
    void Update() {
        if (statekGracza) {
            dist = Vector3.Distance(statekGracza.transform.position, transform.position);
			transform.LookAt(statekGracza.transform.position);
          
        }
		
		if (dist<=250f){

		strzal = true;	
	
			}
		if (ognia.strzal==true){
			strzal = true;
		}
    }
}
