using UnityEngine;
using System.Collections;

public class BirdGenerator : MonoBehaviour {
	
	public Transform bird;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 2f;
	public float tiempoEntreAparicion = 30f;
	
	private float siguienteAparicion;
	
	// Use this for initialization
	void Start () 
	{
		siguienteAparicion = Time.time + primeraAparicion;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time >= siguienteAparicion){
			siguienteAparicion = Time.time + tiempoEntreAparicion;
			Transform birdTransform = Instantiate(bird, objetoRotacion.transform.position, objetoRotacion.transform.rotation) as Transform;
			birdTransform.parent = marcador;
			Rotar rotar = birdTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
