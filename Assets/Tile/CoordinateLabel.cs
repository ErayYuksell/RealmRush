using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteAlways] // bu komut altindaki kodlarin hem duzenleme modunda hemde play modda calismasini saglar 
public class CoordinateLabel : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinats = new Vector2Int();

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates(); // oyunu baslattigimda son konumu gostersin diye 1 kez calistiriyorum
        UpdateObjectName();
    }
    void Update()
    {
        if (!Application.isPlaying) // oyun calismiyorsa yaptigimiz her degisikligi aninda gosterecek ancak oyunu baslattigimda hicbir degisikligi goremeyecegim
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
    }

    void DisplayCoordinates()
    {
        coordinats.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinats.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        label.text = coordinats.x + "," + coordinats.y;
    }
    void UpdateObjectName()
    {
        transform.parent.name = coordinats.ToString();
    }
}
