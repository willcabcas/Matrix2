
namespace Matrix.DAL
{
    using Matrix.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HomeDAL:BaseDAL
    {
        public int resetDB(int numCasosPrueba)
        {
            
            using (aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context context = new aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context())
            {
                try
                {
                    var prueba = context.Cubo3D;
                    context.Cubo3D.RemoveRange(prueba);               
                    context.SaveChanges();

                    var opc2 = context.Opciones.FirstOrDefault(x => x.Id == 1);
                    opc2.NumeroCasoPruebasT = numCasosPrueba;                   
                    context.SaveChanges();
                    return 0;
                }
                catch (Exception exp)
                {
                    string msg;
                    msg = exp.Message;
                    return 1;
                }
            }
            return 0;
        }
               

        public int crearCubo3D(int tamanoCubo3D, int numeroOperaciones)
        {

            using (aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context context = new aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context())
            {
                try
                {
                   
                    for (int i=0; i<tamanoCubo3D; i++)
                    {
                        for (int j=0; j<tamanoCubo3D; j++) {
                            for (int z=0; z<tamanoCubo3D; z++) {
                                Cubo3D informacion = new Cubo3D();
                                informacion.X = i;
                                informacion.Y = j;
                                informacion.Z = z;
                                informacion.Valor = 0;
                                var prueba = context.Cubo3D.Add(informacion);
                                context.SaveChanges();
                            }
                        }
                        
                    }
                    

                    var opc2 = context.Opciones.FirstOrDefault(x => x.Id == 1);
                    opc2.NumeroOperacionesM = numeroOperaciones;
                    opc2.TamanoMatrizN = tamanoCubo3D;
                    context.SaveChanges();
                    return 0;
                }
                catch (Exception exp)
                {
                    string msg;
                    msg = exp.Message;
                    return 1;
                }
            }
            return 0;
        }

        public int updateCubo3D(int x1, int y1, int z1, int val)
        {
            using (aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context context = new aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context())
            {
                try
                {
                    var opc2 = context.Cubo3D.FirstOrDefault(x => x.X == x1 && x.Y==y1 && x.Z==z1);
                    opc2.Valor= val;                    
                    context.SaveChanges();
                    return 0;
                }
                catch (Exception exp)
                {
                    string msg;
                    msg = exp.Message;
                    return 1;
                }
            }
            return 0;
        }


        public int queryCubo3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            using (aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context context = new aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context())
            {               
                var sumatoria = (from a in context.Cubo3D                            
                            where (a.X >= x1 && a.X<= x2) && (a.Y>=y1 && a.Y<=y2)  && (a.Z>=z1 && a.Z<=z2)
                            select a.Valor
                            ).ToList().Sum();

                return sumatoria;
            }           
        }

    }
}
