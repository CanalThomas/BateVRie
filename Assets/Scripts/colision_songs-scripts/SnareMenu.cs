using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnareMenu : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoObjet)
    {

        if (infoObjet.gameObject.tag == "Drumsteaks" )
        {
            int State = 0 ;
            switch (State)
            {
                case 0:
                    //appeler la fonction qui load tutoscene
                    break;
                case 1:
                    //appeler la fonction qui load TutoDemo
                    break;
                case 5:
                    //musique
                    break;
                default:
                    break;
            }
               
        }

    }
}
