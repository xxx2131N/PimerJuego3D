using UnityEngine;

public interface IMovement
{
    public void Move(transform transform, float speed)
    {
        float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * speed * Time.deltaTime, 0, 0);
    }
    
}
