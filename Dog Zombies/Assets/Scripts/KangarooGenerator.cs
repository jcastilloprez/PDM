using UnityEngine;
using System.Collections;

public class KangarooGenerator : MonoBehaviour {
	
	public Transform kangaroo;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 2f;
	public float tiempoEntreAparicion = 12f;
	
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
			Transform kangarooTransform = Instantiate(kangaroo, objetoRotacion.transform.position, objetoRotacion.transform.rotation) as Transform;
			kangarooTransform.parent = marcador;
			Rotar rotar = kangarooTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
