using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    [SerializeField] private StartBall startBall;
    [SerializeField] private Transform ballObject;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform ballTransform;

    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            rb.useGravity = false;
            ballObject.transform.position = ballTransform.position;       
            startBall.SetIsStartedFalse();
        }
    }
}
