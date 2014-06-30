using UnityEngine;
using System.Collections;

public class GoatGenerator : MonoBehaviour {
	
	public Transform goat;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 5f;
	public float tiempoEntreAparicion = 13f;
	
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
			Vector3 v = new Vector3 (0, 5, 0);
			Transform goatTransform = Instantiate(goat, v, objetoRotacion.transform.rotation) as Transform;
			goatTransform.parent = marcador;
			Rotar rotar = goatTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
