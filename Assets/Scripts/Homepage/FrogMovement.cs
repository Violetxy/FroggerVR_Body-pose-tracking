using System.Collections;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    public float moveStep = 1f; 
    public float frameRate = 1f; 
    public float lifeTime = 20f;

    private Vector2 direction = Vector2.up;

    private float timer = 0f;

    public GameObject frogPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveFrog());
    }

    void Update()
    {

    }

    private IEnumerator MoveFrog()
    {
        while (true)
        {
            //Debug.Log("Moving frog: " + transform.position);
            transform.Translate(direction * moveStep);
            timer += frameRate;

            if (timer >= lifeTime)
            {
                SpawnNewFrog();
                Destroy(gameObject);
                yield break;
            }
            yield return new WaitForSeconds(frameRate);
        }
    }

    private void SpawnNewFrog()
    {
        Quaternion currentRotation = transform.rotation;
        GameObject newFrog = Instantiate(frogPrefab, transform.position, currentRotation * Quaternion.Euler(0,0,180));
    }
}
