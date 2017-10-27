namespace Matrix.BLL
{
    using Matrix.DAL;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HomeBLL
    {
        public int resetDB(int numCasosPrueba)
        {
            return new HomeDAL().resetDB(numCasosPrueba);
        }

        public int crearCubo3D(int tamanoCubo3D, int numeroOperaciones)
        {
            return new HomeDAL().crearCubo3D(tamanoCubo3D, numeroOperaciones);
        }

        public int updateCubo3D(int x, int y, int z, int val)
        {
            return new HomeDAL().updateCubo3D(x,y,z,val);
        }

        public int queryCubo3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            return new HomeDAL().queryCubo3D(x1, y1, z1, x2, y2, z2);
        }
    }
}