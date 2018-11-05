using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Fluce.AutoAssign.DomainModel.FluceAlgorithm;
namespace Fluce.AutoAssign.Test.DomainModel.FluceAlgorithm
{
  public  class FluceAlgorithmTest
    {
        public void Split()
        {
             FluceAlgorithm al
                = new AutoAssign.DomainModel.FluceAlgorithm.FluceAlgorithm();
            
            al.Split();

        }
    }
}
