using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currentHitPoints = 0;
    void Start()
    {
        currentHitPoints = maxHitPoints;
    }


    private void OnParticleCollision(GameObject other) // particel system tarafindan temas olunca calisir
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHitPoints--;

        if (currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
