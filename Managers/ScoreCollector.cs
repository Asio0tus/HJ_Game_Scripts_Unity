using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    private int scores;
    public int Scores => scores;

    [HideInInspector] public int bestResultScore;

    private int bonus;

    protected override void Awake()
    {
        base.Awake();

        bestResultScore = PlayerPrefs.GetInt("LevelProgress:BestResultScore", 0);
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Empty)
        {
            bonus++;
            scores += levelProgress.CurrentLevel * bonus;          

        }

        if(type == SegmentType.Default)
        {
            bonus = 0;
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
