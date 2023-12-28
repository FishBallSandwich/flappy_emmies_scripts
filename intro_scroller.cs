using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro_scroller : MonoBehaviour
{


    [Range(-100f, 100f)]
    public float scrollSpeed = 10f;
    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
