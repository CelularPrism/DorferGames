using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(KnifeManager))]
public class SceneController : MonoBehaviour
{
    [SerializeField] private KnifeManager knifeManager;
    [SerializeField] private UIManager uiManager;

    private int score;

    private void Start()
    {
        knifeManager = GetComponent<KnifeManager>();
        score = 0;
    }

    private void Win()
    {
        Debug.Log("Win");
    }

    public void Lose()
    {
        Debug.Log("Lose");

    }

    public void Hit()
    {
        score++;
        uiManager.UpdateScore(score);
        if (knifeManager.countKnife < 0)
            Win();
    }
}
