using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementAnimation : MonoBehaviour
{
    [SerializeField] private WeightTriggerChanger weightTrigger;
    [SerializeField] private Animator[] animatorArray;
    private const string WEIGHT50 = "Weight50";
    private const string WEIGHT100 = "Weight100";
    private const string WEIGHT150 = "Weight150";
}
