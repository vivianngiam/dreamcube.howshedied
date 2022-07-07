using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGridsToBall : MonoBehaviour
{
    public List<VectorGrid> vectorGrids;

    private void OnEnable()
    {
        Debug.Log("add grids to ball activated");

        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
        if(ballObject != null)
        {
            BallVectorGridActivator ballGridActivator = ballObject.GetComponent<BallVectorGridActivator>();
            ballGridActivator.vectorGrids = vectorGrids;
        }
    }

    private void OnDisable()
    {
        Debug.Log("remove grids to ball activated");

        GameObject ballObject = GameObject.FindGameObjectWithTag("Ball");
        if (ballObject != null)
        {
            BallVectorGridActivator ballGridActivator = ballObject.GetComponent<BallVectorGridActivator>();
            ballGridActivator.vectorGrids.Clear();
        }
    }
}
