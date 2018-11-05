using Fluce.AutoAssign.DomainModel;
using Fluce.AutoAssign.DomainModel.FluceAlgorithm;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using Xunit;

namespace Fluce.AutoAssign.Test.DomainModel.FluceAlgorithm
{
    public class SplitterTests
    {


        public SplitterTests()
        {

        }


        private Splitter CreateSplitter()
        {
            return new Splitter();
        }

        [Fact]
        public void Split_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateSplitter();
            Period<T> toBeSplitted = TODO;
            IList<Period<T>> existed = TODO;

            // Act
            var result = unitUnderTest.Split(
                toBeSplitted,
                existed);

            // Assert
            Assert.Fail();
        }
    }
}
