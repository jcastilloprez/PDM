using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	public GameObject camara;
	public GUIText puntos;
	
	private EstadoJuego estado;
	private float tiempo;
	
	public float tiempoEspera = 3f;
	public string nombre;
	
	// Use this for initialization
	void Start () 
	{
		estado = GetComponent<EstadoJuego>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (estado.gameOver && (Input.GetButtonDown("Fire1") || Input.touchCount > 0) && Time.realtimeSinceStartup > tiempo){
			Time.timeScale = 1f;
			Application.LoadLevel(nombre);
		}
	}
	
	public void PartidaTerminada()
	{
		tiempo = Time.realtimeSinceStartup + tiempoEspera;
		
		estado.gameOver = true;
		Time.timeScale = 0f;
	
		camara.SetActive(true);
		
		if (estado.puntuacion > estado.highScore){ //Record superado
			estado.highScore = estado.puntuacion;
			
			PlayerPrefs.SetInt("highscore", estado.puntuacion); //Guardamos la nueva puntuación
			
			puntos.guiText.text = "New Record " + estado.puntuacion.ToString("D5");
		}
		else { //Record no superado
			puntos.guiText.text = estado.puntuacion.ToString("D5");
		}
	}
}
