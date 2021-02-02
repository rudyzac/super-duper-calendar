using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.UseCases.Tests.ProgressSuite.Integration
{
    public class GetEventTest
    {
        [Fact]
        public void ShouldGetTheRequestedEvent()
        {
            // ARRANGE
            metti nel repository il dato che ti aspetti di ricavare
            prendi un riferimento al repository
            crea ciò che ti aspetti

            // ACT
            invoca il caso d'uso

            // ASSERT
            verifica che quanto restituito dal caso d'uso sia uguale a quel che ti aspetti.
        }
    }
}
