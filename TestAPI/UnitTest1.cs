using InterfellPruebaTecnica.Controllers;
using InterfellPruebaTecnica.Data;
using System;
using System.Threading.Tasks;
using Xunit;

namespace TestAPI
{
    public class UnitTest1
    {

        [Fact]
        public async Task Recor()
        {
          
            int Cantidad = 10;
            var DataSQL = R.CollectionOfDummy<>(Cantidad).AsEnumerable();

            var Datos = R.Fake<IActivityTracker<InterfellPruebaTecnicaContext>>();
            R.CallTo(() =>Datos.Get_All_dataAsync(InterfellPruebaTecnicaContext)).Returns(Task.FromResult(DataSQL));
            var control = new ClientesController(Datos);

            var AcionResultado = await control.GetClientes();

         
            var resultado = (OkObjectResult)actionResult;
            var retornaData = (IEnumerable<InterfellPruebaTecnicaContext>)resultado.Value;
            Assert.Equal(Cantidad, retornaData.Count());
        }

       
    
    }
}
