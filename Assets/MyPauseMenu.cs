using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine;

public class MyPauseMenu : MonoBehaviour
{
    public static bool IsOn = false;

    private NetworkManager networkManagerForMenu;

    private void Start()
    {
        networkManagerForMenu = NetworkManager.singleton;
    }

    public void LeaveRoom()
    {
        MatchInfo matchInfo = networkManagerForMenu.matchInfo;
        networkManagerForMenu.matchMaker.DropConnection(matchInfo.networkId, matchInfo.nodeId, 0, networkManagerForMenu.OnDropConnection);
        networkManagerForMenu.StopHost();
    }

    public void doquit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
