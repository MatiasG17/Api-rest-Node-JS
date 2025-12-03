using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace swCinestar.Controllers
{
    [WebService(Namespace = "http://oaemdl.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class swCinestar : System.Web.Services.WebService
    {
        Controllers.CinestarController controller = new Controllers.CinestarController();

        [WebMethod]
        public DataSet getCines()
        {
            return controller.getCines();
        }
        [WebMethod]
        public DataSet getPeliculas(string id)
        {
            return controller.getPeliculas(id);
        }
        [WebMethod]
        public DataSet getPelicula(string id)
        {
            return controller.getPelicula(id);
        }
    }

}
