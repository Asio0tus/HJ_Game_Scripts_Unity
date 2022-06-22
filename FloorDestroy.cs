using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroy : BallEvents
{
    [SerializeField] private BallController ball;
        
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            ball.floorObject.gameObject.GetComponent<Animator>().enabled = true;
            ball.floorObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;           
        }
    }

    /*private void Update()
    {
        if (ball.floorObject.gameObject != null)
        {
            Debug.Log(ball.floorObject.gameObject.transform.position.y.ToString());            

            if (ball.floorObject.gameObject.transform.position.y < 0)
            {
                Object.Destroy(ball.floorObject.gameObject);
            }


        }
    }*/
}
