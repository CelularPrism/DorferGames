using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform panelKnives;
    [SerializeField] private Text scoreText;
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void UpdateCountKnives(int count)
    {
        int index = 0;
        foreach (Transform knive in panelKnives)
        {
            if (index < count)
            {
                knive.gameObject.SetActive(true);
            } else
            {
                knive.gameObject.SetActive(false);
            }
            index++;
        }
    }
}