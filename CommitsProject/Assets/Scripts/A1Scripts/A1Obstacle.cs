using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class A1Obstacle : MonoBehaviour
//abstract obstacle class
{
    public abstract Color DamageColor { get; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(OnDamageDealt(collision.gameObject));
        }
    }

    IEnumerator OnDamageDealt(GameObject target)
    {
        Renderer renderer = target.GetComponent<Renderer>();
        renderer.material.color = DamageColor;
        yield return new WaitForSeconds(1);
        renderer.material.color = Color.white;
    }

    
}
