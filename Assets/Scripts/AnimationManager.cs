using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EffectsManager;
public class AnimationManager : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private long timeVibrate;
    [SerializeField] private Vector3 pos;
    private GameObject knife;

    private void Start()
    {
        knife = null;
    }

    void FixedUpdate()
    {
        if (knife != null)
        {
            knife.transform.position = Vector3.MoveTowards(knife.transform.position, pos, speed);
            if (knife.transform.position == pos)
                knife = null;
        }
    }

    public void EnableAnimation(GameObject gameObject)
    {
        knife = gameObject;
    }

    public void VibratePhone()
    {
        EffectsManager.Vibrate(timeVibrate);
    }
}
