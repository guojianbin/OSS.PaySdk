﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OSS.PayCenter.Samples.Controllers
{


    public class HPayController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var config = new WxPayCenterConfig();
            //config.SetCertificata = (handler, cert) =>
            //{
            //    handler.ServerCertificateCustomValidationCallback = (msg, c, chain, sslErrors) => true;
            //    handler.ClientCertificates.Add(cert);
            //};
            return View();
        }
    }
}
