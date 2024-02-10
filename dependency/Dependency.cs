namespace dependency
{
    public interface Idependency
    {
        Guid id { get; }
    }
    public interface AddTransientOperation : Idependency
    {

    }
    public interface AddScopeOperation : Idependency
    {

    }
    public interface AddSingleToneOperation : Idependency
    {

    }
    public interface AddSingleToneInstance : Idependency
    {
    
    }
    public class Dependency :AddTransientOperation ,AddSingleToneOperation ,AddScopeOperation,AddSingleToneInstance
    {
        Guid _id;

        public Dependency() : this(Guid.NewGuid())
        {

        }

        public Dependency(Guid id)
        {
            _id = id;
        }
        public Guid id => _id;
    }
}
