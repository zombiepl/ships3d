using UnityEngine;
using System.Collections;
using System;//oba w celu obslugi zapisu/odczytu pliku
using System.IO;
using System.Linq;

public class gui : MonoBehaviour {

public static float wspX = 0;
public static float wspY = 0;
public static float wys = 0;
public string SwspX;
public string SwspY;
public string Swys;	
public float czasFrame,czasGry,czasGry2;
public static bool pokaMenu, pokaZapisWyniku,pokaRekordy;
public string nazwaGracza;//zmienan linia
public string [] linie;
public int ileLinii;



	void Start () {
		pokaMenu= false;
		pokaZapisWyniku=false;
		pokaRekordy=false;
		
	}
	


	void Update () {
	czasFrame = Time.deltaTime;
	czasGry=Time.time;
				if (Input.GetKey("escape"))
		{		
						pokaMenu=true;
		}
	if (rozgrywka.wygrales==false)
			czasGry2=czasGry;
	}
	
    void OnGUI() {
		if (rozgrywka.wygrales==false){
		GUI.BeginGroup (new Rect (20, 20, 300, 65));//Screen.height / 2 - 300
		GUI.Box(new Rect(0, 0, 300, 65), "");
		GUI.Label(new Rect(10, 0, 500, 20), "predkosc: "+sterowanieStatkiem.speed+"0"+" wezlow");
		GUI.Label(new Rect(10, 15, 500, 20), "pozostalo "+rozgrywka.ileObiektow+" statkow do zniszczenia");
		GUI.Label(new Rect(10, 30, 500, 20), "zycie: "+sterowanieStatkiem.zycie+"%");
		GUI.Label(new Rect(10, 45, 500, 20), "czas gry: "+Time.time);
		GUI.EndGroup(); 
		}
		if (pokaMenu==true){
		{if (GUI.Button (new Rect (Screen.width/2-50,Screen.height/2,100,30), "Ukryj"))
		{pokaMenu=false;}
		if (GUI.Button (new Rect (Screen.width/2-50,Screen.height/2+60,100,30), "Od nowa"))
		{Application.LoadLevel (2);
		sterowanieStatkiem.zycie=100;		
				}}	
		if (GUI.Button (new Rect (Screen.width/2-50,Screen.height/2+120,100,30), "Wyjscie"))
		{Application.Quit();}}
		
			if (rozgrywka.wygrales==true)//true)
		{
			//pokaRekordy=true;
			pokaZapisWyniku=true;
		}

		
		if (pokaRekordy==true)	
		{
			CzytajPlik("ala.txt");
		
			GUI.color = Color.green;
			GUI.BeginGroup (new Rect (Screen.width/2-150,Screen.height/2-50, 300, (3+zawartoscPliku.Length)*20));
			GUI.Box(new Rect(0, 0, 300, (3+zawartoscPliku.Length)*20), "");
			GUI.Label(new Rect(10,0,200,23),"Wyniki: ");
			GUI.Label(new Rect(10,20,200,23),"Czas:      gracz:");
				for (int i=0;i<ileLinii;i++){//od 0 do ileLinii
					GUI.Label(new Rect(10,(2+i)*20,200,23), zawartoscPliku[i]);}//
			GUI.EndGroup();
			pokaZapisWyniku=false;	
			
		}
		
			if (pokaZapisWyniku==true){		
			
			GUI.Label(new Rect(Screen.width/2-40, Screen.height/2, 80, 23), "WYGRALES");
			GUI.Label(new Rect(Screen.width/2-250,Screen.height/2+70,150,23),"Czas gry:"+czasGry2);
			GUI.Label(new Rect(Screen.width/2-100,Screen.height/2+70,100,23),"Wpisz imie:");
			nazwaGracza = GUI.TextField(new Rect(Screen.width/2,Screen.height/2+70,150,23), nazwaGracza, 25);
			if (GUI.Button(new Rect(Screen.width/2+160,Screen.height/2+70, 60, 23), "Zapisz"))
			{
				CzytajPlik("ala.txt");
     			nowaZawartosc = new string[zawartoscPliku.Length + 1];
				for(int i = 0 ; i < zawartoscPliku.Length ; i++)
					nowaZawartosc[i] = zawartoscPliku[i];
				nowaZawartosc[nowaZawartosc.Length - 1] = czasGry2 + "  " + nazwaGracza;
				
				Array.Sort(nowaZawartosc);
				ZapiszPlik("ala.txt");
				pokaRekordy=true;

			}
		}
		

    }
	public string[] zawartoscPliku;
	public string[] nowaZawartosc;
void CzytajPlik(String file) 
{  
   if(File.Exists(file))
   { 

	  zawartoscPliku = File.ReadAllLines(file);
	  ileLinii = zawartoscPliku.Length;// zwraca ilosc linii;
		
  
   }
   else
   { 
      Debug.Log("Error opening: " + file + " for reading."); 
      return; 
   } 
}//do f. czytajplik

void ZapiszPlik (String nazwaPlikuTxt)
{
	File.WriteAllLines(nazwaPlikuTxt, nowaZawartosc);
	GUI.Label(new Rect(Screen.width/2-150, Screen.height/2, 80, 23), "llallllalalala");
}//do ZapiszPlik
	
}

