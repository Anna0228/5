using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Computer
        {
            public IComputerState State { get; set; }

            public Computer(IComputerState cs)
            {
                State = cs;
            }

            public void TurnOn()
            {
                State.TurnOn(this);
            }
            public void TurnOff()
            {
                State.TurnOff(this);
            }
        }

        public interface IComputerState
        {
            void TurnOn(Computer computer);
            void TurnOff(Computer computer);
        }

        public class TurnOnComputerState : IComputerState
        {
            public void TurnOn(Computer computer)
            {
                Console.WriteLine("Превращаем лед в жидкость");
                computer.State = new TurnOffComputerState();
            }

            public void TurnOff(Computer computer)
            {
                Console.WriteLine("Продолжаем заморозку льда");
            }
        }
        public class TurnOffComputerState : IComputerState
        {
            public void TurnOn(Computer computer)
            {
                Console.WriteLine("Превращаем жидкость в пар");
                computer.State = new TurnOnComputerState();
            }

            public void TurnOff(Computer computer)
            {
                Console.WriteLine("Превращаем жидкость в лед");
                computer.State = new TurnOffComputerState();
            }
        }
        
    }
}
