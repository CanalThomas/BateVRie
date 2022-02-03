using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_song_tomHigh : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource tickSource;
    void Start()
    {
        tickSource.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons de tom High
            tickSource.Play();
        }
    }
}
