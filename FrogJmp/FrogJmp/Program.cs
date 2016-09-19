using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            FrogJump jump = new FrogJump()
            {
                actualPosition = 10,
                defaultJump = 30
            };

            int desiredDistance = 85;
            int jumpsRequired;

            StartJumping(jump, desiredDistance, out jumpsRequired);
            Present(jump, desiredDistance, jumpsRequired);
        }

        static void Present(FrogJump jump, int desired, int jumpsRequired)
        {
            Console.WriteLine("Default jump: {0}", jump.defaultJump);
            Console.WriteLine("First position: {0}", jump.actualPosition);
            Console.WriteLine("Desired position: {0}", desired);
            Console.WriteLine("Needed jumps to get there: {0}", jumpsRequired);
            Console.ReadKey();
        }

        static void StartJumping(FrogJump jump, int desired, out int jumpsRequired)
        {
            int current = jump.actualPosition;
            int jumps = 0;
            while (!IsItAlreadyThere(current, desired))
            {
                Jump(jump, out current);
                jump.actualPosition = current;
                jumps++;
            }
            jumpsRequired = jumps;
        }

        static void Jump(FrogJump jump, out int currentDistance)
        {
            currentDistance = jump.actualPosition + jump.defaultJump;
        }

        static bool IsItAlreadyThere(int current, int desired)
        {
            if (current >= desired)
                return true;
            return false;
        }
        
    }
}
