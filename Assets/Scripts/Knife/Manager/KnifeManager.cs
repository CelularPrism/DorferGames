using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private SpawnerKnives spawnerKnives;
    public MovementKnife[] movementKnives;
    public int countKnife;

    private void Start()
    {
        countKnife = movementKnives.Length;
        spawnerKnives = GetComponent<SpawnerKnives>();
    }

    public MovementKnife GetKnife()
    {
        MovementKnife movementKnife = new MovementKnife();
        countKnife -= 1;
        if (countKnife >= 0)
        {
            uiManager.UpdateCountKnives(countKnife);
            spawnerKnives.SpawnKnive();
            movementKnife = spawnerKnives.GetMovement();
        }

        return movementKnife;
    }
}
