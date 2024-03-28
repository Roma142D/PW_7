using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        Player player = new Player();
        player.ShowStat();
        player.TakeDamage(10);

        Dragon dragon = new Dragon();
        dragon.TakeDamage(15); 
    }
}
