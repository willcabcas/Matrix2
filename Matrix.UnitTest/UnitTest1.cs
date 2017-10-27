using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix.BLL;

namespace Matrix.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private HomeBLL homebll = new HomeBLL();

        [TestMethod]
        public void CrearCubo3d()
        {
            homebll.crearCubo3D(3,4);
        }

        [TestMethod]
        public void ResetValDataBase() {
            homebll.resetDB(4);
        }

        [TestMethod]
        public void updateCubo3D() {
            homebll.updateCubo3D(1,2,1,25);
        }

        [TestMethod]
        public void queryCubo3D() {
            homebll.queryCubo3D(0, 0, 0, 1, 1, 1);
        }
    }
}
