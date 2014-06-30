using UnityEngine;
using System.Collections;

public class DuckGenerator : MonoBehaviour {
	
	public Transform duck;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 7f;
	public float tiempoEntreAparicion = 23f;
	
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
			Vector3 v = new Vector3 (0, 1, 0);
			Transform duckTransform = Instantiate(duck, v, objetoRotacion.transform.rotation) as Transform;
			duckTransform.parent = marcador;
			Rotar rotar = duckTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
