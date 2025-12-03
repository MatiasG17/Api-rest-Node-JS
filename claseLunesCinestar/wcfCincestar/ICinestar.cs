using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfCincestar
{
    [ServiceContract]
    public interface ICinestar
    {
        [OperationContract]
        DataSet getCines();

        [OperationContract]
        DataSet getCines(int id);

        [OperationContract]
        DataSet getPeliculas(int id);

        [OperationContract]
        DataSet getPelicula(int id);
    }
}
