using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomHighMenu : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoObjet)
    {

        if (infoObjet.gameObject.tag == "Drumsteaks")
        {
            int State = 0;
            switch (State)
            {
                case 0:
                    //appeler la fonction qui load freeScene
                    break;
                case 1:
                    //appeler la fonction qui load playmode
                    break;
                case 5:
                    //appeler Start
                default:
                    break;
            }

        }

    }
}
