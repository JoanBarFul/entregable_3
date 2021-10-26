using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float scale = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        { transform.localScale -= new Vector3(scale, 0, 0); }

        if (Input.GetKeyDown(KeyCode.Z))
        { transform.localScale -= new Vector3(0, 0, scale); }

        if (Input.GetKeyDown(KeyCode.Y))
        { transform.localScale -= new Vector3(0, scale, 0); }
    }
}
