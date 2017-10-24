using UnityEngine;
using System.Collections;

public class rozgrywka : MonoBehaviour {
public static int iloscWrogow;
Transform spawn;
public Transform spawn1;
public Transform spawn2;
int i;
public static int ileObiektow;
GameObject[] obiektyEnemy;
public static bool wygrales;
	
	
	void Start () {
		wygrales = false;
		iloscWrogow = 10;//10
		spawn = spawn1;
		for (i=1;i<=iloscWrogow;i++){
			if (i%2==1)
				spawn=spawn1;
			else 
				spawn=spawn2;
	GameObject pociskPref = (GameObject)Instantiate(Resources.Load("statekWroga"),(spawn.position+ new Vector3(i*30,0,0)),spawn.rotation);
		
		}
		

	}
	

	void Update () {

obiektyEnemy = GameObject.FindGameObjectsWithTag("Enemy");
ileObiektow=obiektyEnemy.Length;

		
		
if (ileObiektow<=0)
		{
		wygrales = true;	
		}
		
	//	wygrales=most.wygrales;
	}
}
