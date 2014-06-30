using UnityEngine;
using System.Collections;

public class FishGenerator : MonoBehaviour {
	
	public Transform fish;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 3f;
	public float tiempoEntreAparicion = 15f;
	
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
			Transform fishTransform = Instantiate(fish, v, objetoRotacion.transform.rotation) as Transform;
			fishTransform.parent = marcador;
			Rotar rotar = fishTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
