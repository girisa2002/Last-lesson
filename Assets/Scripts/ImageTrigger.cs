using UnityEngine;

public class ImageTrigger : MonoBehaviour
{
    [Tooltip("Объект Image на Canvas, который будет включаться и выключаться.")]
    public GameObject fullScreenImage;

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошел игрок.
        if (other.CompareTag("Player"))
        {
            // Включаем картинку.
            if (fullScreenImage != null)
            {
                fullScreenImage.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Проверяем, что игрок вышел из триггера.
        if (other.CompareTag("Player"))
        {
            // Выключаем картинку.
            if (fullScreenImage != null)
            {
                fullScreenImage.SetActive(false);
            }
        }
    }
}