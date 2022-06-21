using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSetting : MonoBehaviour
{
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material segmentTrapMaterial;
    [SerializeField] private Material segmentDefaultMaterial;
    [SerializeField] private Material segmentFinishMaterial;
    [SerializeField] private Material axisMaterial;
    [SerializeField] private Image backgroundImage;

    private int indexColor;

    private Color32[] ballAndFinishColor = new Color32[4];
    private Color32[] segmentTrapColor = new Color32[4];
    private Color32[] segmentDefaulColor = new Color32[4];
    private Color32[] axisColor = new Color32[4];
    private Color32[] backgroundColor = new Color32[4];

    private void Start()
    {
        SetColorIndex();
        indexColor = Random.Range(0, 2);

        ballMaterial.color = ballAndFinishColor[indexColor];
        segmentTrapMaterial.color = segmentTrapColor[indexColor];
        segmentDefaultMaterial.color = segmentDefaulColor[indexColor];
        segmentFinishMaterial.color = ballAndFinishColor[indexColor];        
        axisMaterial.color = axisColor[indexColor];
        backgroundImage.color = backgroundColor[indexColor];
    }

    private void SetColorIndex()
    {
        //Ball&Finish

        ballAndFinishColor[0] = new Color32(205, 149, 27, 255);
        ballAndFinishColor[1] = new Color32(35, 142, 24, 255);
        ballAndFinishColor[2] = new Color32(0, 0, 0, 0);
        ballAndFinishColor[3] = new Color32(0, 0, 0, 0);

        //Trap

        segmentTrapColor[0] = new Color32(174, 32, 32, 255);
        segmentTrapColor[1] = new Color32(193, 62, 32, 255);
        segmentTrapColor[2] = new Color32(0, 0, 0, 0);
        segmentTrapColor[3] = new Color32(0, 0, 0, 0);

        //Default

        segmentDefaulColor[0] = new Color32(58, 49, 49, 255);
        segmentDefaulColor[1] = new Color32(203, 158, 32, 255);
        segmentDefaulColor[2] = new Color32(0, 0, 0, 0);
        segmentDefaulColor[3] = new Color32(0, 0, 0, 0);

        //Axis

        axisColor[0] = new Color32(160, 160, 160, 255);
        axisColor[1] = new Color32(203, 158, 32, 255);
        axisColor[2] = new Color32(0, 0, 0, 0);
        axisColor[3] = new Color32(0, 0, 0, 0);

        //Background

        backgroundColor[0] = new Color32(76, 79, 90, 255);
        backgroundColor[1] = new Color32(186, 219, 142, 255);
        backgroundColor[2] = new Color32(0, 0, 0, 0);
        backgroundColor[3] = new Color32(0, 0, 0, 0);
    }
    
}
