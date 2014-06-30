using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		rigidbody.AddForce(transform.forward * 1000);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter (Collider otro)
	{
		if(otro.name == "Suelo"){
			EliminarDisparo();
		} else if (otro.tag == "Padre"){
			EliminarDisparo();
			otro.SendMessage("MuerePadre", SendMessageOptions.DontRequireReceiver);
		} else if (otro.tag == "Hijo"){
			EliminarDisparo();
			otro.SendMessage("Muere", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	void EliminarDisparo()
	{
		Destroy(gameObject, 1);
		GetComponentInChildren<ParticleSystem>().enableEmission = false;
	}
}
