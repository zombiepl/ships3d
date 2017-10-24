using UnityEngine;
using System.Collections;

public class zdrowie : MonoBehaviour {

int distanceLimit = 20;
float szybkosc = 20f;
public float aizdrowie = 100;
Vector3 pozycjaStartowa;
	
	// Use this for initialization
	void Start () {
	pozycjaStartowa=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
			print(aizdrowie);
	        if(aizdrowie <= 0)
        Destroy(gameObject);
		//if (Vector3.Distance(transform.position,Bron.pozycjaGracza)<distanceLimit)
		//{
		// transform.position = Vector3.Lerp(pozycjaStartowa, Bron.pozycjaGracza,Time.time/szybkosc);//Time.time/szybkosc
			
	//	}
		//if ((transform.position-Bron.pozycjaGracza)<=2)//jesli jest za blisko gracza to niech sie zatrzyma
		//	transform.position=transform.position;
			
	}
	
	public void applyDamage(float damage)
{
	audio.Play();
    aizdrowie=aizdrowie-damage;
}
	
}
