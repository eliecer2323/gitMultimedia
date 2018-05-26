using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localidades : MonoBehaviour
{

	public AudioSource fuente;
    public GameObject locAnterior;
    public GameObject pergaminoActivo;

	// Use this for initialization
	void Start()
	{
        locAnterior = new GameObject();
        locAnterior.AddComponent<Image>();
        pergaminoActivo = null;
	}

    public void CerrarVentana()
    {
        pergaminoActivo.SetActive(false);
        pergaminoActivo = null;
    }

	public void Reproducir()
	{
		fuente.Play();
	}

	void Update()
	{
		if (pergaminoActivo==null)
		{
			//Debug.Log("Pressed left click, casting ray.");
			CastRay();
		}
	}

    void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 0);
		if (hit)
		{
			//Debug.Log(hit.collider.gameObject.name);
			GameObject localidad = hit.collider.gameObject;
            if (locAnterior != localidad)
            {
                Image imgLocalidad = localidad.GetComponent<Image>();
                //imgLocalidad.enabled = !imgLocalidad.enabled;
                imgLocalidad.enabled = true;
           
                locAnterior.GetComponent<Image>().enabled = false;
                Reproducir();
            }
            locAnterior = localidad;

            if (Input.GetMouseButtonDown(0))
            {
                GameObject pergamino = localidad.transform.Find("pergamino").gameObject;
                pergamino.SetActive(true);
                pergaminoActivo = pergamino;
            }
        }
    }

}