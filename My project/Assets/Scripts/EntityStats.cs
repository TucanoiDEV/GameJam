using UnityEngine;

public class Entity_Stats : MonoBehaviour
{
    public float max_hp;
    public float hp;
    public float attack_damage;
    public float baseSpeed;
    public float attack_speed;
    public float attack_range;

    private void Start()
    {
        // Initialize hp to max_hp at the start
        hp = max_hp;
    }

    private void Update()
    {
        // Check for death condition
        Death();
    }
    void Death()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}