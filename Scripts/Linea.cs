using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linea : MonoBehaviour {

	public AudioSource fondo,fuente;
	public AudioClip sonido,clic;
	public Canvas canvasCultura, canvasVias, canvasVestimenta, canvasHechos, canvasLocalidades;
	public Animator animacion;

	public void Start () {
		fuente.clip = clic;
	}

	public void btnVias(){
		animacion.Play ("animacionVias(1)");
		terminarCultura ();
		terminarHechos ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		empezarVias ();
	}

	public void btnTerminarVias(){
		animacion.Play ("animacionVolver");
		terminarCultura ();
		terminarHechos ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
	}


	public void btnHechos(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarCultura ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		empezarHechos ();
	}

	public void btnTerminarHechos(){
		animacion.Play ("animacionVolver");
		terminarVias ();
		terminarCultura ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
	}

	public void btnCultura(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		empezarCultura();
	}

	public void btnTerminarCultura(){
		animacion.Play ("animacionVolver");
		terminarVias ();
		terminarHechos ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
	}

	public void btnVestimenta(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarLocalidades ();
		fuente.Play ();
		empezarVestimenta();
	}

	public void btnTerminarVestimenta(){
		animacion.Play ("animacionVolver");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarLocalidades ();
		fuente.Play ();
	}

	public void btnLocalidades(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarVestimenta ();
		fuente.Play ();
		empezarLocalidades();
	}

	public void btnTerminarLocalidades(){
		animacion.Play ("animacionVolver");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarVestimenta ();
		fuente.Play ();
	}

	public void terminarCultura(){
		canvasCultura.gameObject.SetActive (false);
	}

	public void terminarVias(){
		canvasVias.gameObject.SetActive (false);
	}

	public void terminarVestimenta(){
		canvasVestimenta.gameObject.SetActive (false);
	}

	public void terminarHechos(){
		canvasHechos.gameObject.SetActive (false);
	}

	public void terminarLocalidades(){
		canvasLocalidades.gameObject.SetActive (false);
	}

	public void empezarCultura(){
		canvasCultura.gameObject.SetActive (true);
	}

	public void empezarVias(){
		canvasVias.gameObject.SetActive (true);
	}

	public void empezarVestimenta(){
		canvasVestimenta.gameObject.SetActive (true);
	}

	public void empezarHechos(){
		canvasHechos.gameObject.SetActive (true);
	}

	public void empezarLocalidades(){
		canvasLocalidades.gameObject.SetActive (true);
	}
}

