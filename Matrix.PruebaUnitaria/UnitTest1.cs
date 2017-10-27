using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix.BLL;


namespace Matrix.PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarBorrarInfor()
        {
            var HomeBll = new HomeBLL();
            HomeBll.crearCubo3D(2,3);
        }

    }
}
