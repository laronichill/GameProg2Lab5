using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    public GameObject particleSystemToSpawn;
    public Transform spawnPoint;
    public AudioSource source;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //TODO Shooting logic
            Instantiate(particleSystemToSpawn, spawnPoint.position, spawnPoint.rotation);
            source.Play();
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            // When shoot, but not hit yet, call func here
            // Sound effect of bang bang
            // Shooting rocket
            if (Physics.Raycast(ray,out hit))
            {
                // When hit something BOOM
                // Hurting NPC
                if (hit.collider.tag == "Target")
                {
                    TargetComponent tc = hit.collider.GetComponent<TargetComponent>();
                    if (tc != null)
                    {
                        tc.ProcessHit();
                    }
                }
            }
        }
        
    }
}
