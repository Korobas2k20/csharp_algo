using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        // Удаляем объект в начале игры
        Destroy(gameObject);
    }
}
