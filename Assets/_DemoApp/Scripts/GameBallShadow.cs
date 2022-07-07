using UnityEngine;

public class GameBallShadow : MonoBehaviour
{
    public Transform gameBall;
    public GameObject shadow, trail;

    private void Start()
    {
        shadow.SetActive(false);
        trail.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(gameBall.transform.position.x, 0.0001f, gameBall.transform.position.z);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            shadow.SetActive(!shadow.activeInHierarchy);
            trail.SetActive(!trail.activeInHierarchy);
        }
    }
}
