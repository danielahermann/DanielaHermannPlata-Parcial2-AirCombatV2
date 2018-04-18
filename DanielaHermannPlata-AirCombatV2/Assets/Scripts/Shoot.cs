using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    //public Transform  avion;
    //public GameObject Misil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        // si el usuario presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Creo un game object a partir de la informacion guardada
            // en un prefab

            GameObject misil = GameObject.Instantiate (Resources.Load ("Prefabs/Misil") as GameObject);

            //Hago que else misil sea hijo del avion 
            misil.transform.SetParent(this.transform);

            //Muevo el misil a la posicion 
            misil.transform.localPosition = new Vector3 (0.3f,0f,0f);

            // Saco al misil del avion 
            misil.transform.SetParent(null);

        }

        // mover el avion

        if (Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 0.5f, 0.0f);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -0.5f, 0.0f);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate (0.5f, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate (-0.5f, 0.0f, 0.0f);
		}

        {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
   





	}
}
