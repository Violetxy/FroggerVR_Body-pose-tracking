using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveDistance = 1.0f;
    private float movedistance = 1.0f;
    public float jumpingheight = 1.0f;

    private Rigidbody rb;

    public AudioClip sound1;

    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveForward()
    {
        rb.AddForce(new Vector2(0f, jumpingheight), ForceMode.Impulse);
        transform.position += Vector3.forward * moveDistance;
        AudioSource.PlayClipAtPoint(sound1, transform.position);
    }

    public void MoveBackward()
    {
        transform.position += Vector3.back * moveDistance;
        AudioSource.PlayClipAtPoint(sound1, transform.position);
    }

    public void MoveRight()
    {
        transform.position += Vector3.right * movedistance;
        AudioSource.PlayClipAtPoint(sound1, transform.position);

    }

    public void MoveLeft()
    {
        transform.position += Vector3.left * movedistance;
        AudioSource.PlayClipAtPoint(sound1, transform.position);

    }

    public void MoveUp()
    {
        rb.AddForce(new Vector2(0f, jumpingheight), ForceMode.Impulse);
        AudioSource.PlayClipAtPoint(sound1, transform.position);
    }

    public void Attack()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * bulletSpeed;
    }
}
