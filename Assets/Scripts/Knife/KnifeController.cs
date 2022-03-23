using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KnifeController : MonoBehaviour
{
    [SerializeField] private float radius;
    public SceneController sceneController;
    private void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, Physics2D.AllLayers);
        if (collider != null)
        {
            string layer = LayerMask.LayerToName(collider.gameObject.layer);

            if (layer == "Wood")
            {
                Disabled();
                transform.parent.SetParent(collider.transform);
                sceneController.Hit();
                transform.parent.gameObject.layer = LayerMask.NameToLayer("Knife");
            } else if (layer == "Knife")
            {
                Disabled();
                sceneController.Lose();
                Destroy(transform.parent.gameObject);
            }
        }
    }

    private void Disabled()
    {
        transform.parent.GetComponent<MovementKnife>().enabled = false;
        this.enabled = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
