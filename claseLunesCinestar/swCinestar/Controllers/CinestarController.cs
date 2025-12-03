using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace swCinestar.Controllers
{
    public class CinestarController
    {
        Db db = new Db("cnCinestarSmartAsp");
        internal DataSet getCines()
        {
            db.Sentencia("sp_getPelicula");
            return db.getDataSet();
        }

        internal DataSet getPelicula(string id)
        {
            db.Sentencia("sp_getPeliculas " + (id == "cartelera" ? 1 : 2));
            return db.getDataSet();
        }

        internal DataSet getPeliculas(string id)
        {
            db.Sentencia("sp_getPeliculas " + (id == "cartelera" ? 1 : 2));
            return db.getDataSet();
        }
    }
}