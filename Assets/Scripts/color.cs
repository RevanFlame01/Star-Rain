using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    public Image basket;
    private int basketColor;
    private int points;
    public Text score;

    private void Update()
    {
        score.text = "Points: " + points;
        Debug.Log(basketColor);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "blue" && basketColor == 1)
        {
            points += 10;
        }
        if (collision.gameObject.tag == "green" && basketColor == 2)
        {
            points += 10;
        }
        if (collision.gameObject.tag == "red" && basketColor == 3)
        {
            points += 10;
        }
        if (collision.gameObject.tag == "purple" && basketColor == 4)
        {
            points += 10;
        }
        Debug.Log(points);
        Destroy(collision.gameObject);
    }
    public void _Blue()
    {
        basket.color = new Color(0, 0.2352941f, 1, 0.09803922f);
        basketColor = 1;
    }
    public void _Green()
    {
        basket.color = new Color(0, 1, 0.006186962f, 0.09803922f);
        basketColor = 2;
    }
    public void _Red()
    {
        basket.color = new Color(1, 0, 0, 0.09803922f);
        basketColor = 3;
    }
    public void _Purpule()
    {
        basket.color = new Color(0.8574619f, 0, 1, 0.09803922f);
        basketColor = 4;
    }
}
