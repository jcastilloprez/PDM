using UnityEngine;
using System.Collections;

public class EscapeDogZombie : MonoBehaviour {
	
	public float radioEscapado = 35f;
	public AudioClip risa;
	
	private Rotar rotar;
	private EstadoJuego estado;
	
	// Use this for initialization
	void Start () 
	{
		rotar = GetComponent<Rotar>();
		estado = ControladorJuego.ObtenerComponente<EstadoJuego>("ControladorJuego");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rotar.radioActual >= radioEscapado){
			ZombieEscapado();
		}
	}
	
	private void ZombieEscapado()
	{
		Destroy(gameObject);
		estado.PerderUnaVida();

		AudioSource.PlayClipAtPoint(risa, transform.position);
	}
}
