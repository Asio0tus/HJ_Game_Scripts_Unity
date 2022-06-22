using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlotSpawn : BallEvents
{
    [SerializeField] private GameObject blotPrefab;    
    [SerializeField] private Transform levelParent;
    [SerializeField] private Transform ballVisualModel;
    [SerializeField] private float offset;
      

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Default || type == SegmentType.Trap)
        {
            GameObject blot = Instantiate(blotPrefab, levelParent);

            blot.transform.position = new Vector3(ballVisualModel.position.x, transform.position.y + offset, ballVisualModel.position.z);
            blot.transform.eulerAngles = new Vector3(90, Random.Range(0, 360), 0);

        }
        
    }
}
