using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace CalculaArea
{
    /// <summary>
    /// Descripción breve de CalculaAreaWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculaAreaWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos este es mi servicio web(Carlos Eduardo Gómez de la Cruz)";
        }

        [WebMethod]
        public double Area_Circulo(decimal Radio)
        {
            Calcular c = new Calcular();
            return c.circulo(Radio);
        }
        [WebMethod]
        public double Area_Triangulo(decimal Base, decimal Altura)
        {
            Calcular c = new Calcular();
            return (double)c.triangulo(Base,Altura);
        }
        [WebMethod]
        public double Area_Cuadrado(decimal Lado)
        {
            Calcular c = new Calcular();
            return (double)c.cuadrado(Lado);
        }


    }
}
