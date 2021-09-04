using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Screw : MonoBehaviour
{

    public UnityEvent onStart;
    public float distanceToPlayer;
    public float dangerDistance = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("VR Camera");
        distanceToPlayer = Vector3.Distance(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));

        if(PlayerStats.pilotStats.avarageScrewDistance == 0)
        {
            PlayerStats.pilotStats.avarageScrewDistance = distanceToPlayer;
        }

        else
        {
            PlayerStats.pilotStats.avarageScrewDistance = (PlayerStats.pilotStats.avarageScrewDistance + distanceToPlayer)/2;
        }


        if (distanceToPlayer <= dangerDistance)
        {
            PlayerStats.pilotStats.errors++;
            GetComponent<AudioSource>().Play();
        }
        onStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        /*if(other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }*/
    }
}
