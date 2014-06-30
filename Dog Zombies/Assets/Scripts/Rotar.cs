using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour 
{
	
	public Transform objetoRotacion;
	public float rotacionSegundo = 75f; //En grados
	public float radioActual = 2f;
	public float incremento = 0.5f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		radioActual += incremento * Time.deltaTime;
		
		transform.position = new Vector3(objetoRotacion.position.x, transform.position.y, objetoRotacion.position.z);
		
		transform.Translate(-radioActual, 0, 0);
		transform.RotateAround(objetoRotacion.position, Vector3.up, rotacionSegundo * Time.deltaTime);
	}
}
