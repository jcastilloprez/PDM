using UnityEngine;
using System.Collections;

public class BearGenerator : MonoBehaviour {
	
	public Transform bear;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 8f;
	public float tiempoEntreAparicion = 67f;
	
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
			Vector3 v = new Vector3 (-90, 180, 0);
			Transform bearTransform = Instantiate(bear, objetoRotacion.transform.position, Quaternion.LookRotation(v)) as Transform;
			bearTransform.parent = marcador;
			Rotar rotar = bearTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
