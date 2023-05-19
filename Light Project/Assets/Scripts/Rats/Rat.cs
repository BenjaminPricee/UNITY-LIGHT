using UnityEngine;

public class Rat : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            Die();
        }
    }

    private void Die()
    {
        GameObject.Destroy(gameObject);
        //Find Scoermanaher
    }
}
