using UnityEngine;
using System.Collections;

public class ogniaNPC : MonoBehaviour {
	float czas;
	float czas2 = 0;
	float speed;//szybkosc przeladowania wroga
	void Start () {
	speed = Random.Range(5f,20f);
	}
	

	void Update () {
		
	if (bronNPC.strzal==true){
	strzel();
		
		}
		
	}
	
	void strzel()
	{
		
		czas = Time.deltaTime;
		czas2 = czas2+czas;
		if (czas2 >= speed)
		{
		if (sterowanieStatkiem.StatekGraczaZniszczony==false){
		GameObject pociskPref = (GameObject)Instantiate(Resources.Load("pociskPrefNPC"),transform.position,transform.rotation);
		czas2 = 0;
		Debug.Log("wrog wystrzelil")	;	
		}	}
		}

	
}
