using UnityEngine;
using System.Collections;

public class ognia : MonoBehaviour {

	
string nazwa;
public RaycastHit hit;
private float distance = 2000;	
public static bool strzal;
public static Vector3 rayTrafiony;
public static Vector3 pozycjaGracza;
public static Vector3 kierStrzalu;
public static GameObject pociskPref;

	// Use this for initialization
	void Start () {

		strzal=false;
	}

	
void Update ()
{
		
		pozycjaGracza=transform.position;

        //zdrowie.aizdrowie = zdrowie.aizdrowie - bulletDamage;
		//rayTrafiony=hit.transform.position;
		    if(Input.GetKeyDown ("space")) //(Input.GetButtonDown("Fire1"))
			
    {

			strzal = true;
			audio.Play();
			GameObject pociskPref = (GameObject)Instantiate(Resources.Load("pociskPref"),transform.position,transform.rotation);
			
			
			//instantiatedBullet Rigidbody = Instantiate (bulletObject, gunObject.transform.position, gunObject.transform.rotation);  //nie uzywac. nie od tego
	
			
			kierStrzalu=Vector3.forward ;//Vector3.forward//zwraca 0.0.1
			
			
			
			
		//	Debug.Log("ognia.kierstrzalu:"+kierStrzalu);
		Debug.DrawRay (transform.position, -transform.up*distance,Color.green);	
			
		 Vector3 fwd = transform.TransformDirection(Vector3.up);
			if (Physics.Raycast(transform.position,fwd,distance)) //transform.position, transform.forward,out hit, distance))//ics.Raycast(transform.position,fwd,distance))
        {           
					rayTrafiony=hit.point;
          //  if(hit.collider.gameObject.tag == "Enemy")//    if(hit.collider.gameObject.tag == "Enemy")
         //   {
			//	rayTrafiony=hit.collider.transform.position;
				
			//	GameObject Enemy=hit.collider.gameObject;
			//	Enemy.BroadcastMessage("applyDamage",bulletDamage);
				
                
          //  }
        }
    }
		


	
		
	}


}
