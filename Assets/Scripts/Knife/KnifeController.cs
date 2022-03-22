using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KnifeController : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private float radius;
    private void FixedUpdate()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, Physics2D.AllLayers);
        if (collider != null)
        {
            string layer = LayerMask.LayerToName(collider.gameObject.layer);

            if (layer == "Wood")
            {
                transform.parent.GetComponent<MovementKnife>().enabled = false;
                transform.parent.SetParent(collider.transform);
                // Изменить rotation на 0
                sceneController.Hit();
                this.enabled = false;
            } else if (layer == "Knife")
            {
                sceneController.Lose();
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
