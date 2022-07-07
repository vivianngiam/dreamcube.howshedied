using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVectorGridActivator : MonoBehaviour
{
    public List<VectorGrid> vectorGrids;

    public BallCalculator ballCalculator;
    public float explosiveForce = 1.0f;
    public float forceRadius = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float ballSpeed = ballCalculator.velocity.magnitude;
        //float ballForce = explosiveForce * Time.deltaTime * ballSpeed;
        float ballForce = explosiveForce * Time.deltaTime * 40f * ballSpeed;

        foreach (var vectorGrid in vectorGrids)
        {
            vectorGrid.AddGridForce(transform.position, ballForce, forceRadius, Color.white, hasColor: false);
        }
    }
}
