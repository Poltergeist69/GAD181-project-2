using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    [SerializeField] float potrolspeed = 1f;
    [SerializeField] Transform[] patrolPoints;
    [SerializeField] int patrolindex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Patroling(patrolPoints[patrolindex].position);
        patrolToNextPoint();
    }
    void Patroling(Vector2 positionToGo)
    {
        transform.position = Vector2.Lerp(transform.position, positionToGo, Time.deltaTime * potrolspeed);
    }
    void patrolToNextPoint()
    {
       
        float distance = Vector2.Distance(transform.position, patrolPoints[patrolindex].position);
        Debug.Log(distance);

        if(distance <= 1)
        {
            patrolindex++;
        }
        if (patrolindex > patrolPoints.Length - 1)
        {
            patrolindex = 0;
            return;
        }
    }
}
