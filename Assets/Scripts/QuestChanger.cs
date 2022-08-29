using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestChanger : MonoBehaviour
{
    public int idQuestToChange = 0;
    public QUEST_STATUS newQuestStatus;
    [Space]
    [Header("Changer")]
    public bool needMision = false;
    public QUEST_STATUS needStatus;
    public UnityEvent onChangeQuest;
    public void ChangeQuestStatus()
    {
        if(needMision)
        {
            if(QuestManager.instance.GetQuestStatus(idQuestToChange) == needStatus)
            {
                ChangeQuest();
            }
        }
        else
        {
            ChangeQuest();
        }
        
    }
    public void ChangeQuest()
    {
        onChangeQuest?.Invoke();
        QuestManager.instance.SetQuestStatus(idQuestToChange, newQuestStatus);
    }
}
