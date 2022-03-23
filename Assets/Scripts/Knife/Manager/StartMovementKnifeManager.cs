using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(KnifeManager))]
public class StartMovementKnifeManager : MonoBehaviour
{
    [SerializeField] private KnifeManager knifeManager;

    public MovementKnife knife;
    private void Start()
    {
        knifeManager = GetComponent<KnifeManager>();
    }

    void Update()
    {
        Touch[] touch = Input.touches;

        if (touch.Length > 0)
        {
            if (touch[0].phase == TouchPhase.Began)
            {
                knife.isMove = true;
                knife = knifeManager.GetKnife();
            }
        }
    }
}
