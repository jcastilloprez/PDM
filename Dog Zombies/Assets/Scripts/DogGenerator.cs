using UnityEngine;
using System.Collections;

public class DogGenerator : MonoBehaviour {
	
	public Transform dog;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 67f;
	public float tiempoEntreAparicion = 48f;
	
	private float siguienteAparicion;
	
	public float tiempo = 300f;
	public float velocidadInicial = 75f;
	public float velocidadTiempo = 200f;
	public float radioInicial = 0.5f;
	public float radioTiempo = 0.75f;
	
	private float diferenciaVelocidad;
	private float diferenciaRadio;
	
	// Use this for initialization
	void Start () 
	{
		siguienteAparicion = Time.time + primeraAparicion;
		
		diferenciaVelocidad = velocidadTiempo - velocidadInicial;
		diferenciaRadio = radioTiempo - radioInicial;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time >= siguienteAparicion){
			siguienteAparicion = Time.time + tiempoEntreAparicion;
			CrearDog(marcador, objetoRotacion);
		}
	}
	
	void CrearDog (Transform padre, Transform centro)
	{
		Vector3 v = new Vector3 (0, 5, 0);
		Transform dogTransform = Instantiate(dog, v, centro.transform.rotation) as Transform;
		dogTransform.parent = padre;
		Rotar rotar = dogTransform.GetComponent<Rotar>();
		rotar.objetoRotacion = centro;
		
		float valorVelocidad = ((diferenciaVelocidad * Time.timeSinceLevelLoad) / tiempo) + velocidadInicial;
		float valorRadio = ((diferenciaRadio * Time.timeSinceLevelLoad) / tiempo) + radioInicial;
		
		rotar.rotacionSegundo = valorVelocidad;
		rotar.incremento = valorRadio;
	}
}
