namespace dependency
{
    public interface Idependency
    {
        Guid id { get; }
    }
    public interface OperationTransient : Idependency
    {

    }
    public interface OperationScoped : Idependency
    {

    }
    public interface OperationSingleTone : Idependency
    {

    }
    public interface OperationSingleToneInstance : Idependency
    {
    
    }
    public class Dependency : OperationTransient, OperationSingleTone, OperationScoped, OperationSingleToneInstance
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
