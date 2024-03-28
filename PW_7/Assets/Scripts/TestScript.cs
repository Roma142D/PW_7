using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        Person person = new Person();
        person.ShowStat();
        Player player = new Player();
        player.ShowStat(); 
    }
}
