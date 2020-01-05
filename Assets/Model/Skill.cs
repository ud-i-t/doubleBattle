using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    private MasterSkillData _masterData;

    public string Name => _masterData.Name;

    public Skill(MasterSkillData masterData)
    {
        _masterData = masterData;
    }

    public void Use(IBattler user, IBattler target, IMessage message)
    {
        message.Message = $"{user.Name}の{Name}！ {target.Name}に{_masterData.Power}のダメージ";
        target.HP -= _masterData.Power;
    }
}
