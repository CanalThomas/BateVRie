using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TomMediumMenu : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoObjet)
    {

        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            int State = 0;
            switch (State)
            {
                case 0:
                    Application.Quit();
                    break;
                case 1:
                case 5:
                    //appeler la fonction qui load MainScene
                    break;
                default:
                    break;
            }

        }

    }
}
