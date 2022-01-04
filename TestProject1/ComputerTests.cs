using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5;

namespace TestProject1
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void PressButtonTest()
        {
            IComputerState state = new TurnOffComputerState();
            _5.Computer computer = new(state);

            Assert.IsTrue(computer.State is TurnOffComputerState);
            computer.PressButton();
            Assert.IsTrue(computer.State is TurnOnComputerState);
            computer.PressButton();
            Assert.IsTrue(computer.State is TurnOffComputerState);
        }
    }
}
