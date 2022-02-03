using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_tom_low : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tickSource;
    void Start()
    {
        tickSource.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons de tom low
            Debug.Log("collision tom low");
            tickSource.Play();
        }
    }
}
