using System;


public class Enemy
{
  private int hp = 20;
  private string name = "Goomba";

  public void SetHp(int h)
  {
    hp = h;
    if (hp < 0) hp = 0;
  }

  public int GetHp()
  {
    return hp;
  }


  public void PrintName()
  {
    Console.WriteLine(name);
  }

  public void Attack()
  {
    Console.WriteLine($"{name} Attackerar!");
  }

  public void Heal()
  {
    hp += 10;
    if (hp > 20)
    {
      hp = 20;
    }
  }
}
