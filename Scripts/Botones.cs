using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botones : MonoBehaviour {

	public AudioSource fuente;
	public AudioSource fondo;
	public AudioSource boton;
	public AudioClip clip;
	public AudioClip sonido;
	public AudioClip botonSonido;
	public Animator animacion;

	public void Start () {
		fuente.clip = clip;
	}

	public void btnSalir (){
		boton.Stop();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Salir", fuente.clip.length);
	}

	public void btnAmerica (){
		animacion.Play ("animacion1");
		boton.Stop();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar1_2", fuente.clip.length);
	}

	public void btnColombia(){
		animacion.Play ("animacion2");
		boton.Stop();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar2_3", fuente.clip.length);
	}

	public void btnCundinamarca(){
		animacion.Play ("animacion3");
		boton.Stop();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar3_4", fuente.clip.length);
	}

	public void btnBogota(){
		animacion.Play ("animacion4");
		boton.Stop();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar4_5", fuente.clip.length);
	}

	public void btnNarración(){
		boton.Stop ();
		fondo.Stop ();
		fuente.Play ();
		Invoke ("iniciarSonido", fuente.clip.length);
	}
		
	public void Salir(){
		Application.Quit ();
	}

	public void Empezar1_2 (){
		SceneManager.LoadScene ("Guion2");
	}

	public void Empezar2_3 (){
		SceneManager.LoadScene ("Guion3");
	}

	public void Empezar3_4 (){
		SceneManager.LoadScene ("Guion4");
	}

	public void Empezar4_5 (){
		SceneManager.LoadScene ("Guion5");
	}
		
	public void iniciarSonido(){
		fondo.Play ();
	}


}
