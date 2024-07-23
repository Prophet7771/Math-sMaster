using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMaths : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float a = 9f;
        float b = 3f;
        float c = 1f / 3f;
        float d = 1f;

        float answer = a - b / c + d;

        Debug.Log($"{answer}");
    }

    // Update is called once per frame
    void Update() { }
}
