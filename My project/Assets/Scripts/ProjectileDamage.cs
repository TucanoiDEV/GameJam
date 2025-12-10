using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{

    public float projectile_damage;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 1.5f); // Destroy the projectile after 5 seconds to prevent memory leaks
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Entity_Stats>().hp -= projectile_damage;
            Destroy(this.gameObject);
        }
    }


}