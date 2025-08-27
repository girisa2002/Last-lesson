using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    // Приватная переменная для AudioSource.
    private AudioSource audioSource;

    void Start()
    {
        // Получаем компонент AudioSource при старте игры.
        // Он должен быть на том же игровом объекте, что и этот скрипт.
        audioSource = GetComponent<AudioSource>();

        // Убедимся, что звук не проигрывается сразу.
        if (audioSource != null)
        {
            audioSource.playOnAwake = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошел игрок.
        // Убедитесь, что у вашего игрока есть тег "Player".
        if (other.CompareTag("Player"))
        {
            // Проигрываем звук, если AudioSource существует и у него есть клип.
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
        }
    }
}