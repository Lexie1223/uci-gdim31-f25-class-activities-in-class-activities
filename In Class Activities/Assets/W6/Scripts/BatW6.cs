using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private Transform _cat;
    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _cat.position,
                _speed * Time.deltaTime
            );
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
