using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using Excepciones;

namespace Test_Unitario
{
    [TestClass]
    public class PlantaConFruto_Test
    {
        [TestMethod]
        public void TestUltimoId_01()
        {
            
            int idEsperado;
           
            idEsperado = PlantaConFruto.UltimoId();

            Assert.IsNotNull(idEsperado);
        }


        [ExpectedException (typeof(EscribirTxtExceptionConFruto))]
        [TestMethod]
        public void TestEscribirTxt_01()
        {
            List<PlantaConFruto> listaTest = new List<PlantaConFruto>();
            listaTest = null;
            string archivo = "TestArchivo";

            PlantaConFruto.EscribirTxt(listaTest, archivo);

            Assert.IsTrue(true);

        }



    }
}
