using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogoText;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private List<string> dialogues;
    [SerializeField] private int idQuestNPC;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvasGroup.alpha = 1;
            QUEST_STATUS actualQuest = 
                QuestManager.instance.GetQuestStatus(idQuestNPC);
            switch(actualQuest)
            {
                case QUEST_STATUS.UNASSIGNED:
                    dialogoText.text = dialogues[0];
                    QuestManager.instance.
                        SetQuestStatus(idQuestNPC, QUEST_STATUS.ASSIGNED);
                    break;
                case QUEST_STATUS.ASSIGNED:
                    dialogoText.text = dialogues[1];
                    break;
                case QUEST_STATUS.COMPLETE:
                    dialogoText.text = dialogues[2];
                    break;
            }
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasGroup.alpha = 0;
        }
    }
}
