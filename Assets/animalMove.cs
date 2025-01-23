using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalMove : MonoBehaviour
{
    public float movSpeed = 2f;
    public float changeInterval = 3f;
    public float boundaryRadius = 5f;

    private Vector2 vector2;
    private Vector3 vector3;
    // Start is called before the first frame update
    void Start()
    {
        vector3 = transform.position;
        StartCoroutine(ChangeMovementDirection());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vector2 * movSpeed * Time.deltaTime);
        Vector3 distanceFromStart = transform.position - vector3; 
        if(distanceFromStart.magnitude > boundaryRadius)
        {
            Vector3 fromOriginToObject = transform.position - vector3;
            fromOriginToObject *= boundaryRadius / fromOriginToObject.magnitude;
            transform.position = vector3 + fromOriginToObject;
        }
    }

    System.Collections.IEnumerator ChangeMovementDirection()
    {
        while (true)
        {
            float angle = Random.Range(0f, 36f);
            vector2 = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

            yield return new WaitForSeconds(changeInterval);
        }
    }
}
