using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCarTrigger : MonoBehaviour
{
    [SerializeField] private CarMovement carMovement;
    [SerializeField] private TimeSecondsCar timeSecondsCar;

    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            carMovement.ResetCarPosition();
        }
    }
}
