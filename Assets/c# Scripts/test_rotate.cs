using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_rotate : MonoBehaviour
{
    private bool isRotating = false;
    private Vector3 mouseStartPos;

    [SerializeField]
    private float rotationSpeed = 2f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    isRotating = true;
                    mouseStartPos = Input.mousePosition;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 currentMousePos = Input.mousePosition;
            Vector3 mouseOffset = currentMousePos - mouseStartPos;

            // Определяем направление вращения
            Vector3 rotationDirection = new Vector3(mouseOffset.y, -mouseOffset.x, 0f);

            // Нормализуем вектор направления, чтобы сохранить постоянную скорость вращения
            rotationDirection.Normalize();

            // Масштабируем вектор направления для медленного вращения
            rotationDirection *= rotationSpeed;

            // Применяем вращение к объекту
            transform.Rotate(rotationDirection, Space.World);

            mouseStartPos = currentMousePos;
        }
    }
}