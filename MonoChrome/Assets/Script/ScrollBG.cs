using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x = transform.position.x * 0.05f;
        offset.y = transform.position.y * 0.05f;
        mat.mainTextureOffset = offset;
    }
}
