using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCarTrigger : MonoBehaviour
{
    [SerializeField] private CarMovement carMovement;
    private bool IsEnterStartCollider;
    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            carMovement.MoveCar();
            IsEnterStartCollider = true;
            Debug.Log("Car Enter Trigger!!");
        }            
    }

    public bool GetIsEnterStartCollider() => IsEnterStartCollider;
}
