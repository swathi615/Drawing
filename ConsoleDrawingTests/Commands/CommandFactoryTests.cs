using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleDrawing.Commands.Tests
{
    [TestClass()]
    public class CommandFactoryTests
    {
        private Canvas dummyCanvas = new Canvas(100, 100);

        [TestMethod()]
        public void CreateCommandInstanceTest()
        {
            AssertExpectedCommandType("C", typeof(CreateCanvasCommand));
            AssertExpectedCommandType("L", typeof(CreateLineCommand));
            AssertExpectedCommandType("R", typeof(CreateRectangleCommand));
            AssertExpectedCommandType("B", typeof(FillAreaCommand));
            AssertExpectedCommandType("Q", typeof(QuitCommand));
        }

        private void AssertExpectedCommandType(string cmd, System.Type expectedType)
        {
            var cmdInstance = CommandFactory.CreateCommandInstance(cmd, dummyCanvas);
            Assert.IsInstanceOfType(cmdInstance, expectedType);
        }
    }
}
