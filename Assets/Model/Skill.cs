using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    public void Use(IBattler user, IBattler target, IMessage message)
    {
        message.Message = $"{user.Name}の攻撃！ {target.Name}に{1}のダメージ";
        target.HP--;
    }
}
