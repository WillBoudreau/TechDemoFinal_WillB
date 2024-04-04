
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    public float GunDamage = 10f;
    public float GunRange = 100f;
    public Transform Muzzle;

    public Camera FPSCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject MuzzleFlash;
            MuzzleFlash = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            MuzzleFlash.GetComponent<Renderer>().material.SetColor("_Color",Color.yellow);
            MuzzleFlash.transform.localScale = new Vector3(1,1,1);
            MuzzleFlash.transform.position = Muzzle.transform.position;
            Fire();
            Destroy(MuzzleFlash,0.25f);
        }
    }
    void Fire()
    {
        RaycastHit hit;
        if(Physics.Raycast(Muzzle.transform.position,Muzzle.transform.forward, out hit, GunRange))
        {
            Debug.Log(hit.transform.name);

            EnemyBehaviour enemy = hit.transform.GetComponent<EnemyBehaviour>();

            if(enemy != null)
            {
                enemy.Damage(GunDamage);
            }
        }
    }
}
