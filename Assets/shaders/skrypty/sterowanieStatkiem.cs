using UnityEngine;
using System.Collections;


public class sterowanieStatkiem : MonoBehaviour {
public static float speed;
Vector3 aktPos;

	public static bool StatekGraczaZniszczony;
	Quaternion rot;
	Vector3 pos; 
	public static int zycie = 100;
	bool kolizjaZiemia;

	void Start () {
	aktPos = transform.position;
	speed=0;
	StatekGraczaZniszczony=false;
	}
	

	void Update () {

			if(Input.GetKey ("up"))
		{
			if (speed<=0.7f)
			speed = speed+0.003f;
		}

			if(Input.GetKey ("down")){

		if (speed>=-0.01f){
		speed=speed-0.005f;	
		//Debug.Log(speed);
					}
	}
		
					if(Input.GetKey ("right"))
		{ 
			if (speed>0)
			transform.RotateAroundLocal(Vector3.up,0.01f);
			
		}
		
					if(Input.GetKey ("left"))
		{
			if (speed>0)
			transform.RotateAroundLocal(Vector3.up,-0.01f);
						
		}
	

		transform.Translate(Vector3.forward *(speed),Space.Self);

	}
void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "pociskPrefNPC") {//.tag == "pociskPref"  tag=="Enemy"
			 Debug.Log("statek zniszczony przez wroga");
		 rot = Quaternion.FromToRotation (Vector3.up,Vector3.up);
		 pos = transform.position;
       	Instantiate(Resources.Load("wybuchWoda"), pos, rot);
			zycie = zycie - 33;
			if (zycie<=0){
		StatekGraczaZniszczony=true;
        Destroy(gameObject,1);
		gui.pokaMenu=true;
			}}
			
		if (collision.gameObject.tag == "Enemy") {//.tag == "pociskPref"  tag=="Enemy"
			 Debug.Log("kolizja ze statkiem wroga");
		 rot = Quaternion.FromToRotation (Vector3.up,Vector3.up);
		 pos = transform.position;
       	Instantiate(Resources.Load("wybuchWoda"), pos, rot);
		zycie =zycie - 100;
			if (zycie<=0){
		StatekGraczaZniszczony=true;
        Destroy(gameObject,1);
		gui.pokaMenu=true;
			}
    }
		
		
		if (collision.gameObject.tag == "Terrain") {//.tag == "pociskPref"  tag=="Enemy"
			 Debug.Log("kolizja z brzegiem");

		speed=0;
		zycie=zycie-10;
						if (zycie<=0){
		StatekGraczaZniszczony=true;
        Destroy(gameObject,1);
		gui.pokaMenu=true;
			}
    }		

}}
	

