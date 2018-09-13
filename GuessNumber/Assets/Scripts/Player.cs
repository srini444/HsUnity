using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

	int health;
	int power;
	string name;

	public Player()
	{
		
	}

	public Player(int health, int power, string name)
	{
		this.health = health;
		this.power  = power;
		this.name = name;


	}

	public void info()
	{
		Debug.Log ("Player Created health : " + this.health + "  Power :" + this.power + " Name :" + this.name);
	}

	public virtual void Attack()
	{
		Debug.Log ("The Player is Attacking");
	}

	public void attack()
	{
		Debug.Log ("The Player is NOT Attacking");
	}
}
