using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pages.Controllers
{
    public class JsController : Controller
    {
        // GET: Js
        public ActionResult Index()
        {
            string JS = string.Empty;

            JS += @"function API(u, context) {
                       var request = $.ajax({
                                        url:  u,
                                        data: context,
                                        dataType: 'json',
                                        type: 'POST',
                                        async: false
                                    });
                        return request.responseJSON;
                    };";

            return JavaScript(JS);
        }
    }
}