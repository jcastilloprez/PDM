using UnityEngine;
using System.Collections;

public class BotonAtras : MonoBehaviour {
	
	public enum Acciones { Salir, Portada }
	
	public Acciones accion;
	public string nombre;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)){
			switch(accion){
			case Acciones.Salir:
				Application.Quit();
				break;
			case Acciones.Portada:
				Application.LoadLevel(nombre);
				break;
			}
		}
	}
}
