using Bing.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Search.Test
{
    public class CSVTests
    {
        [Fact] 
        public void CSVTest()
        {
            var csvData = new List<string[]> { new[] { "1", "John", "Doe" }, new[] { "2", "Jane", "Smith" } };

            var csvStreamerMock = new Mock<ICSVStreamer>();
            csvStreamerMock.Setup(mock => mock.GetCsvFromFile()).Returns(csvData);

            // Act
            var result = csvStreamerMock.Object.GetCsvFromFile();

            // Assert
            Assert.Equal(csvData, result);

        }
    }
}
