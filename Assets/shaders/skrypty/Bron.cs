using UnityEngine;
using System.Collections;

public class Bron : MonoBehaviour {

public static Quaternion rotacja;

public Texture celownik;
float	vectorx ;
float	vectory ;
public Quaternion startRot;	
void Start () {
 // Screen.showCursor = false;
	startRot = transform.rotation	;
}	
void Update ()
{
		rotacja = transform.rotation;
	//	if(Input.GetKey ("w"))
	//	{transform.RotateAroundLocal(Vector3.right,-0.01f);}//RotateAroundLoca
	//	 if(Input.GetKey ("s"))
	//	{transform.RotateAroundLocal(Vector3.right,0.01f);}
		 if(Input.GetKey ("a"))
		{transform.RotateAroundLocal(Vector3.up,-0.05f);}
		 if(Input.GetKey ("d"))
		{transform.RotateAroundLocal(Vector3.up,0.05f);}
		 if(Input.GetKey ("r"))
		{transform.rotation = startRot ;}
		
//transform.LookAt(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
	
	}
/*
void  OnGUI () {
   vectorx = Input.mousePosition.x;
   vectory = Input.mousePosition.y;
    GUI.DrawTexture(new Rect(vectorx-15,-vectory + Screen.height-15,40,40),celownik);
}	
*/	
	
}
