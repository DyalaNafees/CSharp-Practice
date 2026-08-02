using System;

public class User
{
    private string userName;
    private int health;

    public User(string UserName)
    {
        userName = UserName;
        health = 100;
    }
    public void Heal()
    {
        if (health >= 100)
        {
            Console.WriteLine(userName + " Health is already full");
            health = 100;
        }
        else
        {
            if (health <= 0)
            {
                health = 0;
                health += 10;
            }
            else if (health > 0 && health <= 90)
            {
                health += 10;
                Console.WriteLine(userName + " Healed!  Current Health:" + health + "%");
            }
            else if (health > 90 && health <= 100)
            {
                health = 100;
                Console.WriteLine(userName + " Healed! Current Health:" + health + "%");
            }
            else
            {
                health = 100;
                Console.WriteLine(userName + " Healed! Current Health:" + health + "%");
            }
        }
    }

    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Console.WriteLine(userName + " has been defeated!");
            health = 0;
        }
        else
        {
            Console.WriteLine(userName + " took damage! Remaining Health:" + health + "%");
        }
    }

    public void Attack(User enemy)
    {
        if (this.health <= 0)
            Console.WriteLine(this.userName + " is defeated and cannot attack!");
        else
        {
            Console.WriteLine(this.userName + " Attacked " + enemy.userName);
            enemy.Damage(20);
        }
    }

    public int getHealth()
    {
        return health;
    }

    public string getUserName()
    {
        return userName;
    }
}
public class Program()
{
    public static void Main()
    {
        User p1 = new User("Ali");
        User p2 = new User("Ahmad");

        while (p1.getHealth() > 0 && p2.getHealth() > 0)
        {
            p1.Attack(p2);
            if (p2.getHealth() <= 0)
                break;
            p2.Attack(p1);

            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Game Over");
        if (p1.getHealth() > 0)
        {
            Console.WriteLine(p1.getUserName() + " Wins!");
        }
        else
            Console.WriteLine(p2.getUserName() + " Wins!");

    }
}