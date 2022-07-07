using UnityEngine;
using System.Collections;

public class CollisionPainter : MonoBehaviour{
    public Color paintColor;
    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

    public float timeLeft = 10;
    Color targetColor;


    private void OnCollisionStay(Collision other) {
        Paintable p = other.collider.GetComponent<Paintable>();
        if(p != null){
            Vector3 pos = other.contacts[0].point;
            PaintManager.Instance.paint(p, pos, radius, hardness, strength, paintColor);
        }
    }

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            paintColor = targetColor;
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            paintColor = Color.Lerp(paintColor, targetColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }

}
