using UnityEngine;

public class MoveObjectDuringAnimation : MonoBehaviour
{
    private Animator _animator;
    public float moveSpeed = 50000f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position.x != 5f)
        {
            _animator.Play("Fly Forward");
        }
        else
        {
            _animator.Play("Land");
        }

        // Movimento durante a animação.
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * 2f);
    }
}
