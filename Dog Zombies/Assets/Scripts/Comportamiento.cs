using UnityEngine;
using System.Collections;

public class Comportamiento : MonoBehaviour {
	
	public Transform explosion;
	public AudioClip explota;
	
	private EstadoJuego estado;

	// Use this for initialization
	void Start () 
	{
		estado = ControladorJuego.ObtenerComponente<EstadoJuego>("ControladorJuego");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void MuerePadre ()
	{
		Rotar rotar = transform.parent.GetComponent<Rotar>();
		EscapeDogZombie escaparzombie = transform.parent.GetComponent<EscapeDogZombie>();
		Escapar escapar = transform.parent.GetComponent<Escapar>();
		
		int puntuacion = 0;
		bool cazable = false;
		
		if (gameObject.transform.parent.gameObject.name == "Perro(Clone)"){ 
			puntuacion = (int)((100 * rotar.radioActual) / escaparzombie.radioEscapado);
			cazable = true;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		else if (gameObject.transform.parent.gameObject.name == "Bird(Clone)" || gameObject.transform.parent.gameObject.name == "Fish(Clone)" || gameObject.transform.parent.gameObject.name == "Rabbit(Clone)"){	
			puntuacion = (int)((100 * rotar.radioActual) / escapar.radioEscapado);
			puntuacion = (int)(puntuacion / 2);
			cazable = true;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		else {
			puntuacion = (int)((100 * rotar.radioActual) / escapar.radioEscapado);
			cazable = false;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		
		if (cazable){
			estado.IncrementarPuntuacion(puntuacion);
		}
		else {
			estado.DecrementarPuntuacion(puntuacion);
		}
		
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject.transform.parent.gameObject);	
	}
	
	void Muere ()
	{
		Rotar rotar = transform.GetComponent<Rotar>();
		EscapeDogZombie escaparzombie = transform.GetComponent<EscapeDogZombie>();
		Escapar escapar = transform.GetComponent<Escapar>();
		
		int puntuacion = 0;
		bool cazable = false;
		
		if (gameObject.name == "Zombie(Clone)" || gameObject.name == "Dog(Clone)"){
			puntuacion = (int)((100 * rotar.radioActual) / escaparzombie.radioEscapado);
			cazable = true;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		else if (gameObject.name == "Bear(Clone)" || gameObject.name == "Goat(Clone)"){
			puntuacion = (int)((100 * rotar.radioActual) / escapar.radioEscapado);
			cazable = false;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		else {
			puntuacion = (int)((100 * rotar.radioActual) / escapar.radioEscapado);	
			puntuacion = (int)(puntuacion / 2);
			cazable = true;
			AudioSource.PlayClipAtPoint(explota, transform.position);
		}
		
		if (cazable){
			estado.IncrementarPuntuacion(puntuacion);
		}
		else {
			estado.DecrementarPuntuacion(puntuacion);
		}
		
		Instantiate(explosion, transform.position, transform.rotation);
		Destroy(gameObject);	
	}
}
