using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    private MasterSkillData _masterData;

    public Skill(MasterSkillData masterData)
    {
        _masterData = masterData;
    }

    public void Use(IBattler user, IBattler target, IMessage message)
    {
        message.Message = $"{user.Name}の攻撃！ {target.Name}に{_masterData.Power}のダメージ";
        target.HP -= _masterData.Power;
    }
}
