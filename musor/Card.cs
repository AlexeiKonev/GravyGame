using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 шаблон для авто создания скрипта карты
 */


[CreateAssetMenu(fileName ="New Card", menuName ="Card")]
public class Card : ScriptableObject
{
    public new string name;//имя
    public string description;//описание

    public Sprite artwork;//картинка

    public int manaCost;//мана
    public int attack;//сила атаки
    public int health;//здоровье

}
