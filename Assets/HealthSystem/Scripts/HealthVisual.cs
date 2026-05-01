using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class HealthVisual : MonoBehaviour 
{

    [SerializeField] private Sprite heart0Sprite;
    [SerializeField] private Sprite heart1Sprite;
    [SerializeField] private Sprite heart2Sprite;
    [SerializeField] private Sprite heart3Sprite;
    [SerializeField] private Sprite heart4Sprite;

    private List<HeartImage> heartImageList;
    private void Start()
    {
        CreateHeartImage(new Vector2(0,0));
        CreateHeartImage(new Vector2(20, 0));
        CreateHeartImage(new Vector2(40, 0));
    }
    private Image CreateHeartImage(Vector2 anchoredPosition) { 
        //Create Game Object
        GameObject heartGameObject = new GameObject("Heart", typeof(Image));

        //Set as child of this transform
        heartGameObject.transform.parent = transform;
        heartGameObject.transform.localPosition = Vector3.zero;

        // Locate and Size heart
        heartGameObject.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
        heartGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);

        //Set heart sprite
        Image heartImage = heartGameObject.GetComponent<Image>();
        heartImage.sprite = heart0Sprite;

        return heartImage;
    }

    //Represents a single Heart
    public class HeartImage
    {


    }
}
