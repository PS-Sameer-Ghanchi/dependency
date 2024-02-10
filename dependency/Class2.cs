using Microsoft.AspNetCore.Mvc;

namespace dependency
{
    public class Class2
    {
        private readonly AddTransientOperation _AddTransient;
        private readonly AddScopeOperation _AddScope;
        private readonly AddSingleToneOperation _AddSingleTone;
        private readonly AddSingleToneInstance _addSingleToneInstance;
        public Class2(AddTransientOperation AddTransient2, AddScopeOperation AddScope2, AddSingleToneOperation AddSingleTone2, AddSingleToneInstance Instance)
        {

            _AddTransient = AddTransient2;
            _AddScope = AddScope2;
            _AddSingleTone = AddSingleTone2;
            _addSingleToneInstance = Instance;
        }
        public void get()
        {
            Console.WriteLine("from class 2 ");
            Console.WriteLine($"from AddTransientOperation----{_AddTransient.id}");
            Console.WriteLine($"from AddScopeOperation----{_AddScope.id}");
            Console.WriteLine($"from AddSingleToneOperation----{_AddSingleTone.id}\n\n");
            Console.WriteLine($"from AddScopeOperationInstance----{_addSingleToneInstance.id}");

        }
    }
}
