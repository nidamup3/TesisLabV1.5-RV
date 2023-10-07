using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private WeightTriggerChanger weightTrigger;
    [SerializeField] private StartCarTrigger startCarTrigger;
    [SerializeField] private StopCarTrigger stopCarTrigger;
    [SerializeField] private Transform startTransform;
    [SerializeField] private float velocidadPesoUno;
    [SerializeField] private float velocidadPesoDos;
    [SerializeField] private float velocidadPesoTres;
    private float moveSpeed = 1f;
    private const string WEIGHT50 = "Weight50G";
    private const string WEIGHT100 = "Weight100G";
    private const string WEIGHT150 = "Weight150G";

    private void GetSpeed()
    {
        if (transform.position.x <= -11)
            moveSpeed = 0;

        if (weightTrigger.GetWeight() == WEIGHT50)
            moveSpeed = velocidadPesoUno;

        if (weightTrigger.GetWeight() == WEIGHT100)
            moveSpeed = velocidadPesoDos;

        if (weightTrigger.GetWeight() == WEIGHT150)
            moveSpeed = velocidadPesoTres;
    }

    private void Update()
    {
        
        MoveCar();
    }

    private void CarMovementM()
    {
        GetSpeed();
        if (stopCarTrigger.GetIsCarStopped())
            moveSpeed = 0;

        if (startCarTrigger.GetIsEnterStartCollider())
        {
            Vector3 movement = new Vector3(-moveSpeed, 0f, 0f)  * Time.deltaTime;
            transform.Translate(movement);
        }
    }

    public void ResetCarPosition()
    { 
        transform.position = startTransform.position;
    }

    public void MoveCar() => CarMovementM();
}
