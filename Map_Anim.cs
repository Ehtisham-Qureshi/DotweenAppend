using DG.Tweening;
using UnityEngine;

public class Map_Anim : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform[] obj = new RectTransform[5];
    // Start is called before the first frame update
    void OnEnable()
    {

        obj[0].DOAnchorPosY(1, 1f).SetEase(Ease.OutBack);
        obj[1].DOAnchorPosY(1, 1.1f).SetEase(Ease.OutBack); ;
        obj[2].DOAnchorPosY(1, 1.2f).SetEase(Ease.OutBack);
        obj[3].DOAnchorPosY(1, 1.3f).SetEase(Ease.OutBack);

   
    }

    // Update is called once per frame
    void OnDisable()
    {
        obj[0].DOAnchorPosY(1200, 0.1f);
        obj[1].DOAnchorPosY(1200, 0.1f);
        obj[2].DOAnchorPosY(1200, 0.1f);
        obj[3].DOAnchorPosY(1200, 0.1f);
    }
}
