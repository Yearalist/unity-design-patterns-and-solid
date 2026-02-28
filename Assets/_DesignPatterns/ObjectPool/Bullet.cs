using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 20f;
    private float lifeTime = 2f;
    private float timer = 0f;

    private void OnEnable()
    {
        timer = 0f;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= lifeTime)
        {
            gameObject.SetActive(false);
        }
    }
}
