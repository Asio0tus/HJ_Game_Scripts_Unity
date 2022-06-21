using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    private int scores;
    public int Scores => scores;

    [HideInInspector] public int bestResultScore;

    protected override void Awake()
    {
        base.Awake();

        bestResultScore = PlayerPrefs.GetInt("LevelProgress:BestResultScore", 0);
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;          

        }

        if(type == SegmentType.Finish)
        {
           
            if (scores > bestResultScore)
            {
                bestResultScore = scores;
                PlayerPrefs.SetInt("LevelProgress:BestResultScore", bestResultScore);
            }
        }
    }
}
