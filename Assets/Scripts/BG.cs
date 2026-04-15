using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public Material materialBG;
    public float scrollSpd = 0.3f;

    private void Update()
    {
        Vector2 direction = Vector2.up;
        materialBG.mainTextureOffset += direction * scrollSpd * Time.deltaTime;
    }
}
