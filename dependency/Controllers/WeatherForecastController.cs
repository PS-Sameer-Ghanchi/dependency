using Microsoft.AspNetCore.Mvc;

namespace dependency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly AddTransientOperation _AddTransient;
        private readonly AddScopeOperation _AddScope;
        private readonly AddSingleToneOperation _AddSingleTone;
        private readonly AddSingleToneInstance _addSingleToneInstance;
        private readonly Class1 _Class1;
        private readonly Class2 _Class2;


       
        public WeatherForecastController(AddTransientOperation AddTransient, AddScopeOperation AddScope, AddSingleToneOperation AddSingleTone,Class1 Class1, Class2 Class2, AddSingleToneInstance OneIstance)
        {
           
            _AddTransient= AddTransient;
            _AddScope=AddScope;
            _AddSingleTone=AddSingleTone;
            _Class1 = Class1;
            _Class2 = Class2;
            _addSingleToneInstance = OneIstance;
        }
       
        [HttpGet("api1")]
        public void get() {
           

            Console.WriteLine();
            _Class1.get();
            Console.WriteLine();
            _Class2.get();
            return;
        }
    }
}
