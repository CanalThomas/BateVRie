using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_song_Snare : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tickSource;
    void Start()
    {
        tickSource.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider infoObjet)
    {
        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons de Snare
            tickSource.Play();
        }
    }
}
