namespace Matrix.DAL
{
    using Matrix.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Base para el context de las otras clases
    /// </summary>
    public class BaseDAL
    {
        /// <summary>
        /// Gets el context del sistema.
        /// </summary>
        /// <value>null</value>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context GetContext()
        {
            aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context context = new aspnet_MVC2_DCED3249_C6F3_4707_9B6F_1544191732C7Context();
            return context;
        }
    }
}