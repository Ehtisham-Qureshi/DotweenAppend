using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class Dotween : MonoBehaviour
{
 

    public RectTransform[] obj = new RectTransform [12];
    
    public Vector2 vec = new Vector2(0f,0f);
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Sequence myseq = DOTween.Sequence();
        obj[0].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        obj[1].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        obj[2].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        obj[9].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        obj[10].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        obj[11].DOAnchorPosY(1, 0.9f).SetEase(Ease.InOutBounce);
        myseq.Append(obj[3].DOAnchorPosX(1, 0.1f).SetEase(Ease.InOutBounce));
        myseq.Append(obj[4].DOAnchorPosY(1, 0.2f).SetEase(Ease.OutBounce,3f));
        myseq.Join(obj[5].DOAnchorPosY(1, 0.3f).SetEase(Ease.OutBounce, 3f));
        myseq.Join(obj[6].DOAnchorPosY(1, 0.4f).SetEase(Ease.OutBounce, 3f));
        myseq.Join(obj[7].DOAnchorPosY(1, 0.5f).SetEase(Ease.OutBounce, 3f));
        myseq.Join(obj[8].DOAnchorPosY(1, 0.9f).SetEase(Ease.OutBounce, 3f));
       

    }
    void OnDisable()
    {
        
        obj[0].DOAnchorPosY(600, 0.01f);
        obj[1].DOAnchorPosY(600, 0.01f);
        obj[2].DOAnchorPosY(600, 0.01f);
        obj[3].DOAnchorPosX(100, 0.01f);
        obj[4].DOAnchorPosY(-300, 0.01f);
        obj[5].DOAnchorPosY(-300, 0.01f);
        obj[6].DOAnchorPosY(-300, 0.01f);
        obj[7].DOAnchorPosY(-300, 0.01f);
        obj[8].DOAnchorPosY(-300, 0.01f);
        obj[9].DOAnchorPosY(0, 0.01f);
        obj[10].DOAnchorPosY(0, 0.01f);


    }

    // Update is called once per frame
    void Update()
    {
    }
}
