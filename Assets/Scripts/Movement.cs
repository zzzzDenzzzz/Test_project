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
        // ���������� ��� ���������� ��������
        var moveForwardBackward = 0f;
        var moveLeftRight = 0f;
        var rotate = 0f;

        // �������� ����� � �����
        if (Input.GetKey(KeyCode.W))
        {
            moveForwardBackward += HeroSpeed * 2;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveForwardBackward -= HeroSpeed;
        }

        // �������� ����� � ������
        if (Input.GetKey(KeyCode.Q))
        {
            moveLeftRight -= HeroSpeed;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            moveLeftRight += HeroSpeed;
        }

        // ��������
        if (Input.GetKey(KeyCode.A))
        {
            rotate -= HeroRotateSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate += HeroRotateSpeed;
        }

        // ���������� ��������
        _heroTransform.Translate(moveLeftRight, 0, moveForwardBackward);
        _heroTransform.Rotate(0, rotate, 0);
    }
}