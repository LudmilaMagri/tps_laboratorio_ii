using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace Test_Unitario
{
    [TestClass]
    public class PlantaMusgo_Test
    {
        [TestMethod]
        public void FiltrarCantidadEsporas_01()
        {
            List<PlantaMusgo> lista = new List<PlantaMusgo>();
            PlantaMusgo plantaMusgo = new PlantaMusgo("Dendroligotrichum dendroides", "Polytrichaceae ", "America", 500, 4000, 3000);

            lista.Add(plantaMusgo);

            plantaMusgo.Nombre = PlantaMusgo.FiltrarCantidadEsporas(lista);

            Assert.IsNotNull(plantaMusgo.Nombre);
            Assert.IsTrue(plantaMusgo.Nombre.ToString() != string.Empty);
          
        }
    }
}
