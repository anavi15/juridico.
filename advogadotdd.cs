using System;
using Xunit;

namespace juridicoTDD
{
    public class advogadotdd
    {
        [Fact]
        public void advogadoRetomarNomeCompletoTrue()
        {
            //Arrange - Preparação 
            advogado adv = new advogado();
            adv.Nome = "Vinicius";
            adv.Sobrenome = "Reginaldo";
            string esperado = "Vinicius Reginaldo";
            string resultado;
            //Act
            resultado = adv.getNomeCompleto();

            //Assert
            Assert.Equal(esperado, resultado);

        }
        [Theory]
        [InlineData("Reginaldo", "Vinicius", "Reginaldo Vinicius")]
        [InlineData("josé",)]

        {

    



    internal class advogado
    {
        internal string Nome;
        internal string Sobrenome;

        internal string getNomeCompleto()
        {
            throw new NotImplementedException();
        }
    }
}

