using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Pack.SelfHost.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ColorController : ApiController
    {
        [HttpGet(), ActionName("ListColor")]
        [AllowAnonymous()]
        public HttpResponseMessage List()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HybridDictionary dicColors = new HybridDictionary();
            HttpStatusCode eHttpStatusCodeRetorno = HttpStatusCode.OK;

            try
            {
                dicColors["Title"] = "Translating English to Portuguese.";
                
                dicColors["ColorList"] = this.ReturnColorList();

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }
            catch (Exception ex)
            {
                dicColors["Message"] = ex.Message;
                dicColors["StackTrace"] = ex.StackTrace;

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }

            return response;
        }

        [HttpPost(), ActionName("InsertColor")]
        [AllowAnonymous()]
        public HttpResponseMessage Insert(string color, string translate)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HybridDictionary dicColors = new HybridDictionary();
            HybridDictionary lstDicColors = new HybridDictionary();
            HttpStatusCode eHttpStatusCodeRetorno = HttpStatusCode.OK;

            try
            {
                dicColors["Title"] = "Translating English to Portuguese.";

                lstDicColors = this.ReturnColorList();

                if (!lstDicColors.Contains(color))
                {
                    lstDicColors[color] = translate;

                    dicColors["ColorList"] = lstDicColors;
                }
                else
                {
                    dicColors["Message"] = string.Format("The color {0}, alredy exist.", color);
                }

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }
            catch (Exception ex)
            {
                dicColors["Message"] = ex.Message;
                dicColors["StackTrace"] = ex.StackTrace;

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }

            return response;
        }

        [HttpPost(), ActionName("UpdateColor")]
        [AllowAnonymous()]
        public HttpResponseMessage Update(string color, string translate)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HybridDictionary dicColors = new HybridDictionary();
            HybridDictionary lstDicColors = new HybridDictionary();
            HttpStatusCode eHttpStatusCodeRetorno = HttpStatusCode.OK;

            try
            {
                dicColors["Title"] = "Translating English to Portuguese.";

                lstDicColors = this.ReturnColorList();

                if (lstDicColors.Contains(color))
                {
                    lstDicColors[color] = translate;

                    dicColors["ColorList"] = lstDicColors;
                }
                else
                {
                    dicColors["Message"] = string.Format("The color {0}, not exist.", color);
                }

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }
            catch (Exception ex)
            {
                dicColors["Message"] = ex.Message;
                dicColors["StackTrace"] = ex.StackTrace;

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }

            return response;
        }

        [HttpPost(), ActionName("DeleteColor")]
        [AllowAnonymous()]
        public HttpResponseMessage Delete(string color)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HybridDictionary dicColors = new HybridDictionary();
            HybridDictionary lstDicColors = new HybridDictionary();
            HttpStatusCode eHttpStatusCodeRetorno = HttpStatusCode.OK;

            try
            {
                dicColors["Title"] = "Translating English to Portuguese.";

                lstDicColors = this.ReturnColorList();

                if (lstDicColors.Contains(color))
                {
                    lstDicColors.Remove(color);

                    dicColors["ColorList"] = lstDicColors;
                }
                else
                {
                    dicColors["Message"] = string.Format("The color {0}, not exist.", color);
                }

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }
            catch (Exception ex)
            {
                dicColors["Message"] = ex.Message;
                dicColors["StackTrace"] = ex.StackTrace;

                response = Request.CreateResponse(eHttpStatusCodeRetorno, dicColors);
            }

            return response;
        }

        private HybridDictionary ReturnColorList()
        {
            HybridDictionary lstDicColors = new HybridDictionary();

            lstDicColors["Yellow"] = "Amarelo";
            lstDicColors["Blue"] = "Azul";
            lstDicColors["Red"] = "Vermelho";
            lstDicColors["Green"] = "Verde";
            lstDicColors["Purple"] = "Roxo";
            lstDicColors["Brown"] = "Marrom";

            return lstDicColors;
        }
    }
}
