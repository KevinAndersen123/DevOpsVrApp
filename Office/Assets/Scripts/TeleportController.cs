using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public GameObject m_player;
    public List<GameObject> teleportLocations;

    public void teleportTo(int location)
    {
        m_player.transform.position = new Vector3(teleportLocations[location].transform.position.x,
                                                  teleportLocations[location].transform.position.y,
                                                  teleportLocations[location].transform.position.z);
    }
}
