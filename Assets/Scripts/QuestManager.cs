using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public string nameQuest;
    public string descriptionQuest;
    public int idQuest;
    public QUEST_STATUS statusQuest;
}
public enum QUEST_STATUS
{
    UNASSIGNED, ASSIGNED, COMPLETE
}
public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public List<Quest> quests;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Hay más de un quest manager");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
    }
    public QUEST_STATUS GetQuestStatus(int id)
    {
        foreach(Quest q in quests)
        {
            if(q.idQuest == id)
            {
                return q.statusQuest;
            }
        }
        return QUEST_STATUS.UNASSIGNED;
    }
    public void SetQuestStatus(int id, QUEST_STATUS newQuestStatus)
    {
        foreach (Quest q in quests)
        {
            if (q.idQuest == id)
            {
                q.statusQuest = newQuestStatus;
            }
        }
    }    
}
