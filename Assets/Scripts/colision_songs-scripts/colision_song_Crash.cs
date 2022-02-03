using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_song_Crash : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tickSource;
    void Start()
    {
        tickSource.GetComponent<AudioSource>();
    }
     
    private void OnCollisionEnter(Collider infoObjet)
    {
        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons de Crash
            tickSource.Play();
        }
    }
}
