using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerState state = new TurnOffComputerState();
            Computer computer = new(state);
            computer.PressButton(); //Turning on
            computer.PressButton(); //Turning off
        }
    }

    public class Computer
    {
        public IComputerState State { get; set; }

        public Computer(IComputerState cs)
        {
            State = cs;
        }

        public void PressButton()
        {
            State.ChangeComputerState(this);
        }
    }

    public interface IComputerState
    {
        void ChangeComputerState(Computer computer);
    }

    public class TurnOnComputerState : IComputerState
    {
        public void ChangeComputerState(Computer computer)
        {
            Console.WriteLine("Computer is turning off.");
            computer.State = new TurnOffComputerState();
        }
    }
    public class TurnOffComputerState : IComputerState
    {
        public void ChangeComputerState(Computer computer)
        {
            Console.WriteLine("Computer is turning on.");
            computer.State = new TurnOnComputerState();
        }
    }
}
