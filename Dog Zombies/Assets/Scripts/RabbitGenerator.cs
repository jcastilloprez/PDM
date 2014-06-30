using UnityEngine;
using System.Collections;

public class RabbitGenerator : MonoBehaviour {
	
	public Transform rabbit;
	public Transform objetoRotacion;
	public Transform marcador;
	
	public float primeraAparicion = 6f;
	public float tiempoEntreAparicion = 36f;
	
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
			Vector3 r = new Vector3 (-90, 180, 0);
			Transform rabbitTransform = Instantiate(rabbit, v, Quaternion.LookRotation(r)) as Transform;
			rabbitTransform.parent = marcador;
			Rotar rotar = rabbitTransform.GetComponent<Rotar>();
			rotar.objetoRotacion = objetoRotacion;
		}
	}
}
