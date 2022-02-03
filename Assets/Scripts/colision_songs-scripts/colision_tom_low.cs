using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_arch67 : MonoBehaviour
{
   private void OnTriggerEnter(Collider infoObjet)
    {
        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            //jouer le sons
        }
    }
}
