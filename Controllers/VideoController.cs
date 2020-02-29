using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["Video"]=BaseHelper.ejecutarConsulta("Select*from Video", CommandType.Text);
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, string repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("insert into Video values(@idVideo,@titulo,@repro,@url)", CommandType.Text, parametros);
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Modificar(int idVideo, string titulo,string repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            
            BaseHelper.ejecutarSentencia("Update Video Set titulo=@titulo,repro=@repro,url=@url where idVideo=@idVideo", CommandType.Text, parametros);
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
           
            BaseHelper.ejecutarSentencia("Delete from Video where idVideo=@idVideo", CommandType.Text, parametros);
            return View();
        }

    }
}
