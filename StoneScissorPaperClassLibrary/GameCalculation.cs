using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorPaperClassLibrary
{
    public class GameCalculation
    {
        private Random _rand;
        private int aI;
        private List<string> list = new List<string>();

        public List<string> ResaultCalculation(int user)
        {
            if (user == 1) return Stone(user);

            if (user == 2) return Scissor(user);

            if (user == 3) return Paper(user);

            return list;
        }


        private List<string> Stone(int user)
        {
            list.Clear();
            list.Add("Stone");
            if (AIChoice() == 2) //Stone to scissor = win
            {
                list.Add("scissor");
                list.Add("win");
                return list;
            }
            if (AIChoice() == 3) // Stone to paper = lose
            {
                list.Add("paper");
                list.Add("lose");
                return list;
            }
            else 
            {
                list.Add("stone");
                list.Add("draw");
            }
            return list;  //Stone to Stone = draw    
        }

        private List<string> Scissor(int user)
        {
            list.Clear();
            list.Add("Scissor");
            if (AIChoice() == 1) //Scissor to Stone = lose 
            {
                list.Add("stone");
                list.Add("lose");
                return list;
            }
            if (AIChoice() == 3) //Scissor to paper = win
            {
                list.Add("paper");
                list.Add("win");
                return list;
            }
            else
            {
                list.Add("scissor");
                list.Add("draw");
            }
            return list;  // //Scissor to Scissor = draw
        }

        private List<string> Paper(int user)
        {
            list.Clear();
            list.Add("Paper");
            if (AIChoice() == 1) // Paper to stone = win
            {
                list.Add("stone");
                list.Add("win");
                return list;
            }
            if (AIChoice() == 2)
            {
                list.Add("scissor"); //paper to scissor = lose
                list.Add("lose");
                return list;
            }
            else
            {
                list.Add("paper");
                list.Add("draw");
            }
            return list; //Paper to paper = draw
        }

        private int AIChoice()
        {
            _rand = new Random();
            return aI = _rand.Next(1, 4);
        }
    }
}
