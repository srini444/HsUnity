using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer {

	private int power;
	private int health;
	private string name;


	public NewPlayer()
	{
		power = 100;
		health = 120;
		name = "Srinivas";
	}

	public void SetPower(int power)
	{
		this.power = power;
	}

	public int GetPower()
	{
		return this.power;
	}
}
