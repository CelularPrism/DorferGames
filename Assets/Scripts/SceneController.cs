using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(KnifeManager))]
public class SceneController : MonoBehaviour
{
    [SerializeField] private KnifeManager knifeManager;

    private void Start()
    {
        knifeManager = GetComponent<KnifeManager>();
    }

    private void Win()
    {
        Debug.Log("Are you winning son?");
    }

    public void Lose()
    {
        Debug.Log("Lose");

    }

    public void Hit()
    {
        if (knifeManager.countKnife < 0)
            Win();
    }
}
