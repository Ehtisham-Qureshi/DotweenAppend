using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class Anima : MonoBehaviour
{
    public Sequence seq = DOTween.Sequence();
    public RectTransform[] obj = new RectTransform[5];
    // Start is called before the first frame update
    void  OnEnable()
    {

        seq.Append(obj[0].DOAnchorPosY(1, 0.5f).SetEase(Ease.OutBounce,2.5f));
        seq.PrependInterval(0.2f);
        seq.Append(obj[1].DOAnchorPosY(1, 0.6f).SetEase(Ease.OutBounce, 2.5f));
        seq.PrependInterval(0.2f);
        seq.Append(obj[2].DOAnchorPosY(1, 0.7f).SetEase(Ease.OutBounce, 2.5f));
        seq.PrependInterval(0.2f);
        seq.Append(obj[3].DOAnchorPosY(1, 0.8f).SetEase(Ease.OutBounce, 2.5f));

    }

    // Update is called once per frame
    void OnDisable()
    {
        obj[0].DOAnchorPosY(1200, 0.1f);
        obj[1].DOAnchorPosY(1200, 0.1f); ;
        obj[2].DOAnchorPosY(1200, 0.1f);
        obj[3].DOAnchorPosY(1200, 0.1f);


    }
}
