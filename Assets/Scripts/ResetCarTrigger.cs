using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCarTrigger : MonoBehaviour
{
    [SerializeField] private CarMovement carMovement;

    private void OnTriggerEnter(Collider other)
    {
        carMovement.ResetCarPosition();
    }
}
