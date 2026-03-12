namespace Back_end.models;

[Serializable]
public abstract class Entity : IEquatable<Entity>
{
    public virtual Guid Id { get; set; }

    public virtual bool Equals(Entity other)
    {
        if ((object)other == null)
        {
            return false;
        }

        if (this == other)
        {
            return true;
        }

        if (GetType() != other.GetType())
        {
            return false;
        }

        return other.Id == Id;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (this == (Entity)obj)
        {
            return true;
        }

        if (GetType() != obj.GetType())
        {
            return false;
        }

        return Equals((Entity)obj);
    }

    public override int GetHashCode()
    {
        return (Id.GetHashCode() * 397) ^ GetType().GetHashCode();
    }

    public static bool operator ==(Entity left, Entity right)
    {
        return object.Equals(left, right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !object.Equals(left, right);
    }
}

[Serializable]
public abstract class EntityBase : Entity { }

