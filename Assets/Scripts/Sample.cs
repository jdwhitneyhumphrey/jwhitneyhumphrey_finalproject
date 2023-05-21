using UnityEngine;

public class Sample : MonoBehaviour
{
    public bool IsSolved = false;

    void OnTriggerEnter (Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        if (collidedWith.tag == gameObject.tag)
        {
            IsSolved = true;
            Destroy(collidedWith);
        }
    }
}
