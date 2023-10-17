using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWhereCensorIs : MonoBehaviour
{
    private bool IsHere;
    private const string CENSORTAG = "Censor";
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == CENSORTAG)
        {
            IsHere = true;
            Debug.Log($"Censor is Activated {IsHere}");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == CENSORTAG)
        {
            IsHere = false;
            Debug.Log($"Censor is Activated {IsHere}");
        }
    }

    public bool GetIsHere() => IsHere;
}
