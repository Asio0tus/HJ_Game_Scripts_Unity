using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text bestResultScoreText;
    [SerializeField] private ScoreCollector scoreCollector;

    protected override void OnBallCollisionSegment(SegmentType type)
    {       
        scoreText.text = scoreCollector.Scores.ToString();
        bestResultScoreText.text = scoreCollector.bestResultScore.ToString();
    }
}
