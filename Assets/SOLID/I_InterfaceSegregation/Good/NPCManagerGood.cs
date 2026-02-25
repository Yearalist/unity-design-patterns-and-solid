// GOOD EXAMPLE - Manager interacts with NPCs through their specific interfaces

using UnityEngine;

public class NPCManagerGood : MonoBehaviour
{
    private void Start()
    {
        MonoBehaviour[] allBehaviours = FindObjectsOfType<MonoBehaviour>();

        foreach (MonoBehaviour behaviour in allBehaviours)
        {
            // Check if this is a talkable NPC
            if (behaviour is ITalkable talkable)
            {
                talkable.Talk();
            }

            // Check if this NPC can trade
            if (behaviour is ITradeable tradeable)
            {
                tradeable.Trade();
            }

            // Check if this NPC can fight
            if (behaviour is IFightable fightable)
            {
                fightable.Fight();
            }

            // Check if this NPC can patrol
            if (behaviour is IPatrollable patrollable)
            {
                patrollable.Patrol();
            }
        }
    }
}
