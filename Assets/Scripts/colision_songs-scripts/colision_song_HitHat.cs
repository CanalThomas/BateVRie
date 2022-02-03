using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_song_HitHat : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tickSource;
    void Start()
    {
        Debug.Log("Start");

        tickSource.GetComponent<AudioSource>();
    }
     
    private void OnCollisionEnter(Collision infoObjet)
    {
        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons de Hit-Hat
            Debug.Log("colision");
            tickSource.Play();
        }
    }
}
