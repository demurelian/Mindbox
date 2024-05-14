using Microsoft.AspNetCore.Mvc;
using GeometryLibrary.Model.Figures.Base;
using GeometryLibrary.Model.Figures;
using System.Diagnostics;
using GeometryLibrary.Model;

namespace GeometryLibrary.Controllers
{
    [Controller]
    [Route("test")]
    public class MyController : Controller
    {
        [HttpGet]
        [Route("get")]
        public int GetSum()
        {
            return 2;
        }

        [HttpPost]
        [Route("post")]
        public double PostSum([FromBody] Request request)
        {
            var triangle = new Triangle(request.FirstSide, request.SecondSide, request.ThirdSide);
            var circle = new Circle(request.Radius);
            var listOfFigures = new List<IFigure>
            {
                triangle,
                circle
            };
            var processor = new Processor();
            return processor.SumArea(listOfFigures);
        }
    }
}
