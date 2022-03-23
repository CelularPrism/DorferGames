using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerKnives : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private AnimationManager animationManager;
    [SerializeField] private GameObject prefabKnife;
    private MovementKnife movementKnife;
    private void Start()
    {
        sceneController = GetComponent<SceneController>();
        animationManager = GetComponent<AnimationManager>();
    }

    public void SpawnKnive()
    {
        GameObject prefab = Instantiate(prefabKnife);
        animationManager.EnableAnimation(prefab);
        animationManager.VibratePhone();
        prefab.transform.GetChild(1).GetComponent<KnifeController>().sceneController = sceneController;
        movementKnife = prefab.transform.GetComponent<MovementKnife>();
    }

    public MovementKnife GetMovement()
    {
        return movementKnife;
    }
}
