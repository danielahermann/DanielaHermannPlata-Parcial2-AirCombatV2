using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilFalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) { 

		//Escribir el tag tal cual lo escribimos con mayusuculas y todo 

		if (collision.collider.gameObject.tag == "MarsAlien") {

			//Cargamos el prefab de la explosion 
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/MarsExplosion") as GameObject);

			//Muevo la explosion hacia la nave que fue impactada 
			explosion.transform.position = collision.collider.gameObject.transform.position;


			// Destruimos el objeto impactado por el misil 
			Destroy (collision.collider.gameObject);

			// Destruimos el misil 
			Destroy(this.gameObject);
		}

		if (collision.collider.gameObject.tag == "JupiterAlien") {
			
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/JupiterExplosion") as GameObject);
			explosion.transform.position = collision.collider.gameObject.transform.position;


			// Destruimos el objeto impactado por el misil 
			Destroy (collision.collider.gameObject);

			// Destruimos el misil 
			Destroy (this.gameObject);
		}
	}
}
