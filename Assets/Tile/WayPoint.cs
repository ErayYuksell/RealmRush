using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable = true;
    [SerializeField] GameObject towerPrefab;
    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceable = false; // bu script her bir ground da oldugu icin 1 ine tikladigimda onun scriptinde false olur bu sayede bir daha ayni noktaya tower koyulmaz
        }
    }
}
