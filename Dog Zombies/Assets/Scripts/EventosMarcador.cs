using UnityEngine;
using System.Collections;

public class EventosMarcador : MonoBehaviour {
	
	public GUIText notificacion;
	
	private bool detener;
	
	private EstadoJuego estado;
	
	// Use this for initialization
	void Start () 
	{
		estado = GetComponent<EstadoJuego>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (detener && Time.frameCount >= 2){
			Time.timeScale = 0f;
		}
		
		if (Input.GetKeyDown(KeyCode.Q)){
			MarcadorPerdido();
		}else if (Input.GetKeyDown(KeyCode.W)){
			MarcadorEncontrado();
		}
	}
	
	public void MarcadorEncontrado ()
	{
		if (estado.gameOver) return;
		
		if (notificacion != null){
			notificacion.enabled = false;
		}
		
		//Reanudamos el juego
		Time.timeScale = 1f;
		detener = false;
	}
	
	public void MarcadorPerdido ()
	{
		if (estado.gameOver) return;
		
		if (notificacion != null){
			notificacion.enabled = true;
		}
		
		//Pausamos el juego
		detener = true;
	}
}
