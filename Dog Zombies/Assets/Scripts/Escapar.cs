using UnityEngine;
using System.Collections;

public class Escapar : MonoBehaviour {
	
	public float radioEscapado = 30f;
	public AudioClip escapar;
	
	private Rotar rotar;
	
	// Use this for initialization
	void Start () 
	{
		rotar = GetComponent<Rotar>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rotar.radioActual >= radioEscapado){
			Destroy(gameObject);
			AudioSource.PlayClipAtPoint(escapar, transform.position);
		}
	}
}
