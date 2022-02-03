using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SongOnCollision : MonoBehaviour
{
    private List<AudioSource> listAudio;
    private int count = 0;
    private void Start()
    {
        for (int i=0; i< 10; i++)
        {
            listAudio[i] = GetComponent<AudioSource>();
        }
    }
    private void OnTriggerEnter(Collider infoObjet)
    {

        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            if (count > 9) count = 0;
            if (true) listAudio[count].Play();
            count++;
        }
        
    }
}
