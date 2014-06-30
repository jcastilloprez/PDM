using UnityEngine;
using System.Collections;

public class Empezar : MonoBehaviour {
	
	public string nombre;
	public int espera = 3;
	public TextMesh texto;
	
	private float tiempo;
	
	// Use this for initialization
	void Start () 
	{
		tiempo = Time.time + espera;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time > tiempo){
			texto.renderer.enabled = true;
		}
		
		if (Time.time > tiempo && (Input.GetButtonDown("Fire1") || Input.touchCount > 0)){
			Application.LoadLevel(nombre);
		}
	}
}
