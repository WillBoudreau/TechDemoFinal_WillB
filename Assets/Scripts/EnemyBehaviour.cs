
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
  public float health = 20f;

  public void Damage(float amount)
  {
    health -=amount;
    if(health <= 0f)
    {
        Death();
    }
  }
  void Death()
  {
    Destroy(gameObject);
  }
}
