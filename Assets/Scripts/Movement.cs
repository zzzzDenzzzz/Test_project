using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float HeroSpeed = 0.03f;
    private const float HeroRotateSpeed = 1.0f;

    private Transform _heroTransform;

    private void Start()
    {
        _heroTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        HeroController();
    }

    public void HeroController()
    {
        // Переменные для накопления смещений
        var moveForwardBackward = 0f;
        var moveLeftRight = 0f;
        var rotate = 0f;

        // Движение вперёд и назад
        if (Input.GetKey(KeyCode.W))
        {
            moveForwardBackward += HeroSpeed * 2;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveForwardBackward -= HeroSpeed;
        }

        // Движение влево и вправо
        if (Input.GetKey(KeyCode.Q))
        {
            moveLeftRight -= HeroSpeed;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            moveLeftRight += HeroSpeed;
        }

        // Повороты
        if (Input.GetKey(KeyCode.A))
        {
            rotate -= HeroRotateSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate += HeroRotateSpeed;
        }

        // Применение смещений
        _heroTransform.Translate(moveLeftRight, 0, moveForwardBackward);
        _heroTransform.Rotate(0, rotate, 0);
    }
}