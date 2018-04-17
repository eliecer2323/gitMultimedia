using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placas : MonoBehaviour {

    public AudioSource clic;
	public Animator animacion;
	public Canvas placas;

    public void mostrarPlaca(GameObject gaObj)
    {
		cerrarTodos ();
		animacion.Play ("animacionVias(1)");
		clic.Play ();
//		Invoke (gaObj.tag, fuente.clip.length);
    }

	public void cerrarTodos(){
//		public paneles = placas.GetComponentsInChildren
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
