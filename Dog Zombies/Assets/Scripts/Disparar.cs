using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour 
{
	public Transform disparo;
	public float tiempoEntreDisparo = 0.5f;
	
	private float siguienteDisparo = 0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if((Input.GetButtonDown("Fire1") || Input.touchCount > 0) && Time.time > siguienteDisparo){
			siguienteDisparo = Time.time + tiempoEntreDisparo;
			Instantiate(disparo, transform.position, transform.rotation);
		}
	}
}
