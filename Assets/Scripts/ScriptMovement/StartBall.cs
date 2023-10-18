using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private TiimeSecondBall timeSecondsBall;

    private bool IsStarted;

    private string HANDTAG = "Hand";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == HANDTAG)
        {
            rb.useGravity = true;
            timeSecondsBall.IniciarAccion();
            IsStarted = true;
        }
    }

    public bool GetIsStarted() => IsStarted;
    public void SetIsStartedFalse() => IsStarted = false;
}
