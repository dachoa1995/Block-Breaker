using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnit = 16f;

    GameSession gameSession;
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(getXpos(), transform.position.y);
    }

    private float getXpos()
    {
        if(gameSession.IsAutoplayEnabled())
        {
            return ball.transform.position.x;
        } else
        {
            return Mathf.Clamp(Input.mousePosition.x / Screen.width * screenWidthInUnit, minX, maxX);
        }
    }
}
