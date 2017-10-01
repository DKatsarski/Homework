using Moq;
using NUnit.Framework;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests.Core.Commands.CreateStudentCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        private static readonly string SuccessMessageTemplate = "A new student with name {0} {1}, grade {2} and ID {3} was created.";

        private const string SourcesListVariableName = "_sourceLists";

        private static object[] _sourceLists = {new object[] {new List<string> { "Pesho", "Petrov", "6" }},
                                                new object[] {new List<string> { "Gosho", "Peshev", "9" } }};


        private static Tuple<string, string, Grade> GetParameters(IList<string> parameters)
        {
            return new Tuple<string, string, Grade>(parameters[0], parameters[1], (Grade)int.Parse(parameters[2]));
        }

        [Test, TestCaseSource(SourcesListVariableName)]
        public void CreateStudentWithCorrectParametersByFactory_WhenParametersAreCorrect(IList<string> parameters)
        {
            // Arrange
            var parametersTuple = GetParameters(parameters);
            var mockStudentFactory = new Mock<IStudentFactory>();
            var mockAddStudent = new Mock<IAddStudent>();
            var createStudentCommand = new CreateStudentCommand(mockStudentFactory.Object, mockAddStudent.Object);

            // Act
            createStudentCommand.Execute(parameters);

            // Assert
            mockStudentFactory.Verify(a => a.CreateStudent(parametersTuple.Item1, parametersTuple.Item2, parametersTuple.Item3), Times.Once());
        }
    }
}
