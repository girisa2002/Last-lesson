using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    // ��������� ���������� ��� AudioSource.
    private AudioSource audioSource;

    void Start()
    {
        // �������� ��������� AudioSource ��� ������ ����.
        // �� ������ ���� �� ��� �� ������� �������, ��� � ���� ������.
        audioSource = GetComponent<AudioSource>();

        // ��������, ��� ���� �� ������������� �����.
        if (audioSource != null)
        {
            audioSource.playOnAwake = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� � ������� ����� �����.
        // ���������, ��� � ������ ������ ���� ��� "Player".
        if (other.CompareTag("Player"))
        {
            // ����������� ����, ���� AudioSource ���������� � � ���� ���� ����.
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
        }
    }
}