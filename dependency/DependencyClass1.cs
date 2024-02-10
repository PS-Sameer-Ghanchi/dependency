
namespace dependency
{
    public class DependencyClass1
    {
        private readonly OperationTransient _OperationTransient;
        private readonly OperationScoped _OperationScoped;
        private readonly OperationSingleTone _OperationSingleTone;
        private readonly OperationSingleToneInstance _OperationSingleToneInstance;
        public DependencyClass1(OperationTransient AddTransient2, OperationScoped AddScope2, OperationSingleTone AddSingleTone2, OperationSingleToneInstance Instance)
        {

            _OperationTransient = AddTransient2;
            _OperationScoped = AddScope2;
            _OperationSingleTone = AddSingleTone2;
            _OperationSingleToneInstance = Instance;
        }
        public void get()
        {
            Console.WriteLine("from Dependency Class 1 ");
            Console.WriteLine($"from AddTransientOperation----{_OperationTransient.id}");
            Console.WriteLine($"from AddScopeOperation----{_OperationScoped.id}");
            Console.WriteLine($"from AddSingleToneOperation----{_OperationSingleTone.id}");
            Console.WriteLine($"from AddScopeOperationInstance----{_OperationSingleToneInstance.id}\n\n");

        }
    }
}
