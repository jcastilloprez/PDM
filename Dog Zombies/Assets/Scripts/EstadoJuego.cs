using UnityEngine;
using System.Collections;

public class EstadoJuego : MonoBehaviour {
	
	public GUITexture vidas;
	public Texture[] imagenesVidas;
	
	public int vidasActuales = 0;
	public int vidasIniciales = 3;
	
	public GUIText guiPuntuacion;
	
	public int puntuacion = 0;
	
	internal bool gameOver = false;
	internal int highScore = 0;
	
	// Use this for initialization
	void Start () 
	{
		highScore = PlayerPrefs.GetInt("highscore", 0);
		
		vidasActuales = vidasIniciales;
		
		vidas.guiTexture.texture = imagenesVidas[vidasActuales];
		
		puntuacion = 0;
		ActualizarPuntuacion();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void PerderUnaVida ()
	{
		if (vidasActuales > 0){
			vidasActuales--;
		}
		
		if (vidasActuales < imagenesVidas.Length){
			vidas.guiTexture.texture = imagenesVidas[vidasActuales];
		}
		
		if (vidasActuales <= 0){
			SendMessage("PartidaTerminada", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	public void IncrementarPuntuacion (int valor)
	{
		puntuacion += valor;
		ActualizarPuntuacion();
	}
	
	public void DecrementarPuntuacion (int valor)
	{
		puntuacion -= valor;
		ActualizarPuntuacion();
		
		if (puntuacion < 0){
			SendMessage("PartidaTerminada", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	public void ActualizarPuntuacion ()
	{
		guiPuntuacion.guiText.text = puntuacion.ToString("D5");
	}
}
