using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    
    public static bool gameOver
    { 
    	get {return collectableCount <= 0;}
    }
    
    public static void Init()
    {
    	collectableCount = 5;
    }
    
    public static void Collect()
    {
    	collectableCount--;
    }
    
    public static void Die()
    {
    	collectableCount = 0;
    	GameObject[] all_coins = GameObject.FindGameObjectsWithTag("Coletável");
    	GameObject[] all_enemies = GameObject.FindGameObjectsWithTag("Inimigo");
    	
    	foreach (GameObject coin in all_coins) 
	{
	    UnityEngine.Object.Destroy(coin);
	}

	foreach (GameObject enemy in all_enemies) 
	{
	    UnityEngine.Object.Destroy(enemy);
	}
    }
    
}
