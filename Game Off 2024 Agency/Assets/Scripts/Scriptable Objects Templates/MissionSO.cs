using UnityEngine;

[CreateAssetMenu(fileName = "MissionSO", menuName = "Scriptable Objects/MissionSO")]
public class MissionSO : ScriptableObject
{
    public string missionName;
    public string description;
    public int passCheck;

}
