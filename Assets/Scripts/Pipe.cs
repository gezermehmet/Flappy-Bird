using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float pipeSpeed;
    
    void Update()
    {
        transform.position += Vector3.left * (pipeSpeed * Time.deltaTime);
    }
}