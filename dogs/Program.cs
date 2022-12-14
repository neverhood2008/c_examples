int count=0;
int distance=10000;
int firstfriendspeed=1;
int secondfriendspeed=2;
int dogspeed=5;
int friend=2;
while (distance>10)
{
    if (friend==1)
    {
        Time=distance/(firstfriendspeed+dogspeed);
        friend=2;
    }
    else
    {
         Time=distance/(secondfriendspeed+dogspeed);
         friend=1;
    }   
    }
    distance=distance-(firstfriendspeed+secondfriendspeed)*Time;
    count=count+1
}
Console.WriteLine("собака пробежит ", count , " раз");
