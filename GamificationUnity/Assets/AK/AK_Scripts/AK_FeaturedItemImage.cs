using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_FeaturedItemImage : MonoBehaviour
{
    public float slideTime;
    float timeHolder;

    public Sprite[] itemImages;
    int imageCounter;

    Image image;

    private void Start()
    {
        timeHolder = slideTime;
        imageCounter = 0;
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (slideTime > 0)
        {
            slideTime -= Time.deltaTime;
        }

        if (slideTime <= 0)
        {
            if (imageCounter < itemImages.Length)
                imageCounter++;

            if (imageCounter >= itemImages.Length)
                imageCounter = 0;

            image.sprite = itemImages[imageCounter];

            slideTime = timeHolder;
        }
    }
}

