using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    [SerializeField] private InputActionReference _actionReference = null;
    private Vector3 deplacement;
    private float speedshutZ;


    private void Update()
    {
        if (_actionReference == null || _actionReference.action == null || _actionReference.action.type == InputActionType.Button)
            return;
        
        switch (_actionReference.action.expectedControlType)
        {
            case "Axis":
                speedshutZ = _actionReference.action.ReadValue<float>();  // pour le deplacement en Z
                break;
            case "Vector2":
                 deplacement = _actionReference.action.ReadValue<Vector2>(); // pour le deplacement en x et y 
                break;
            default:
                break;
        }
        if (transform.position.y < Camera.main.transform.position.y)
        {
            transform.Translate(new Vector3(deplacement.x, speedshutZ, deplacement.y));
        }
        else
        {
            transform.Translate(new Vector3(deplacement.x, speedshutZ, -deplacement.y));
        }
    }
}
