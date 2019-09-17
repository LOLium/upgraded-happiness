using UnityEngine;
using UnityEngine.Networking;

public class Host : MonoBehaviour
{
    [SerializeField]
    uint RoomSize = 2;
    private string RoomName;

    private NetworkManager networkManager;

    private void Start()
    {
        networkManager = NetworkManager.singleton;
        if(networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetRoomName(string name)
    {
        RoomName = name;
    }

    public void CreateRoom()
    {
        if(RoomName != "" && RoomName != null)
        {
            Debug.Log("Creating Room: " + RoomName + " with room for " + RoomSize + " players.");
            networkManager.matchMaker.CreateMatch(RoomName, RoomSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
        }
    }
}
