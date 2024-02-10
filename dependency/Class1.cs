
namespace dependency
{
    public class Class1
    {
        private readonly AddTransientOperation _AddTransient;
        private readonly AddScopeOperation _AddScope;
        private readonly AddSingleToneOperation _AddSingleTone;
        private readonly AddSingleToneInstance _addSingleToneInstance;
        public Class1(AddTransientOperation AddTransient, AddScopeOperation AddScope, AddSingleToneOperation AddSingleTone, AddSingleToneInstance Instance)
        {

            _AddTransient = AddTransient;
            _AddScope = AddScope;
            _AddSingleTone = AddSingleTone;
          
            _addSingleToneInstance = Instance;
        }
        public void get()
        {
            Console.WriteLine("from class 1 ");
            Console.WriteLine($"from AddTransientOperation----{_AddTransient.id}");
            Console.WriteLine($"from AddScopeOperation-----{_AddScope.id}");
            Console.WriteLine($"from AddSingleToneOperation----{_AddSingleTone.id}\n\n");
            Console.WriteLine($"from AddScopeOperationInstance----{_addSingleToneInstance.id}");

        }


    }
}
