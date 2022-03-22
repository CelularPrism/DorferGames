using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    MovementKnife[] movementKnives;
    public int countKnife;

    public MovementKnife GetKnife()
    {
        MovementKnife movementKnife = new MovementKnife();
        countKnife -= 1;
        if (countKnife >= 0)
            movementKnife = movementKnives[countKnife];

        return movementKnife;
    }
}
