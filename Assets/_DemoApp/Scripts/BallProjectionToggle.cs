using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallProjectionToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.enabled = !mr.enabled;
        }
    }
}
