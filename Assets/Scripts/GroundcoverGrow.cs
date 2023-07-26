using UnityEngine;

public class GroundcoverGrow : MonoBehaviour
{
    [SerializeField] private GameObject mushroomSource;
    private GameObject mushroom;

    [SerializeField] private Transform _parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Groundcover"))
        {
            Vector3 midPos = (gameObject.transform.position + other.gameObject.transform.position) / 2;
            mushroom = Instantiate(mushroomSource, midPos, gameObject.transform.rotation, _parent);

            Debug.Log("Collision Detected");
            Debug.Log(mushroom);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Groundcover"))
        {
            Destroy(mushroom);
        }
    }
}
