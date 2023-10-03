using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private WeightTriggerChanger weightTrigger;
    [SerializeField] private StartCarTrigger startCarTrigger;
    private float moveSpeed = 1f;
    private const string WEIGHT50 = "Weight50";
    private const string WEIGHT100 = "Weight100";
    private const string WEIGHT150 = "Weight150";

    private void GetSpeed()
    {
        if (transform.position.x <= -11)
            moveSpeed = 0;

        if (weightTrigger.GetWeight() == WEIGHT50)
            moveSpeed = 1f;

        if (weightTrigger.GetWeight() == WEIGHT100)
            moveSpeed = 2f;

        if (weightTrigger.GetWeight() == WEIGHT150)
            moveSpeed = 3f;
    }

    private void Update()
    {
        MoveCar();
    }

    private void CarMovementM()
    {
        GetSpeed();

        if (startCarTrigger.GetIsEnterStartCollider())
        {
            if (transform.position.x >= -11)
            {
                Vector3 movement = new Vector3(-moveSpeed, 0f, 0f)  * Time.deltaTime;
                transform.Translate(movement);
            }

            else
            {
                Vector3 movement = new Vector3(0f, 0f, 0f) * Time.deltaTime;
                transform.Translate(movement);
            }
        }
    }

    public void ResetCarPosition() => transform.position = new Vector3(2.17700005f, 0.458999991f, -1.08500004f);

    public void MoveCar() => CarMovementM();
}
