using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCarTrigger : MonoBehaviour
{
    [SerializeField] private StartCarTrigger startCarTrigger;
    private const string CARTAG = "Car";
    private bool IsCarStopped;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == CARTAG)
        {
            IsCarStopped = true;
            startCarTrigger.SetIsEnterStartColliderFalse();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsCarStopped = false;
    }

    public bool GetIsCarStopped() => IsCarStopped;
}
