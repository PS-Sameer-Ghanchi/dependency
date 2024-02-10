using Microsoft.AspNetCore.Mvc;

namespace dependency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly OperationTransient OperationTransient;
        private readonly OperationScoped _OperationScoped;
        private readonly OperationSingleTone _OperationSingleTone;
        private readonly OperationSingleToneInstance _OperationSingleToneInstance;
        private readonly DependencyClass1 _DependencyClass1;
        private readonly DependencyClass2 _DependencyClass2;


       
        public WeatherForecastController(OperationTransient AddTransient, OperationScoped AddScope, OperationSingleTone AddSingleTone, DependencyClass1 Class1, DependencyClass2 Class2, OperationSingleToneInstance OneIstance)
        {

            OperationTransient = AddTransient;
            _OperationScoped = AddScope;
            _OperationSingleTone = AddSingleTone;
            _DependencyClass1 = Class1;
            _DependencyClass2 = Class2;
            _OperationSingleToneInstance = OneIstance;
        }
       
        [HttpGet("api1")]
        public void get() {
           

            Console.WriteLine();
            _DependencyClass1.get();
            Console.WriteLine();
            _DependencyClass2.get();
            return;
        }
    }
}
