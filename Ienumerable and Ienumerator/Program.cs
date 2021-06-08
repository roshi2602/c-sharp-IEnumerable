using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//IEnumerable is used for iteration over item of class. This IEnumerable interface inherits IEnumerator
//Ienumerable-to enable iterations over item of class, the class should implement Ienumerable interface
//it has method which return Ienumerator = Ineumerator GetEnumerator()
//Ienumerator has 3 methods- Current(), MoveNext(), reset()
//for combined these 3 methods we use Ienumarable 

//var is variables whose data type will be defined at the time of assigning values    
//import using System.Collections;

namespace Ienumerable_and_Ienumerator
{
   

    class Player
    {
        //make 2 properties in it
        public string Name { get; set; }
        public int Roll { get; set; }

        //now create constructor of this class
        public Player(string na, int ro) // 2 paarmeters in it
        {
            //assigning parameters to my properties
            Name = na;
            Roll = ro;
        }
    }


    //now make 1 more class
    class Team : IEnumerable         //Ienumerble is to iteratate through all the items in a class
    {
        //make array
        private Player[] pa = new Player[3];

        //make constructor of Team class
        public Team()
        {
            pa[0] = new Player("jo", 50);
            pa[1] = new Player("priya", 30);
            pa[2] = new Player("pooja", 60);
        }

        //use getEnumerator() method for IEnumerable
        //Ienumarable implements Ienumerator
        public IEnumerator GetEnumerator()
        {
            return pa.GetEnumerator();
        }


        class Program1
        {
            static void Main()
            {

                //instantiate Team class
                Team t = new Team();


                //now iterate through these items
                foreach (Player p in t)            //player in team object
                {
                    Console.WriteLine("{0} , {1}", p.Name, p.Roll);
                    //in order to iterate through all items u need to implement ienumaerable interface ,so define Ienumerable in Team class

                }
                Console.ReadLine();
            }
        }
    }
}