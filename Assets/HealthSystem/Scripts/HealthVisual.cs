using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class HealthVisual : MonoBehaviour 
{

    [SerializeField] private Sprite heartSprite;
    private Image CreateHeartImage() { 
        GameObject heartGameObject = new GameObject("Heart", typeof(Image));
        heartGameObject.transform.parent = transform;
        heartGameObject.transform.localPosition = Vector3.zero;
        Image heartImage = heartGameObject.GetComponent<Image>();
        heartImage.sprite = heartSprite;

        return heartImage;
    }
}
