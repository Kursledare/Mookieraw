namespace EntityData.Interfaces
{
    public interface IDefence
    {
        int Ac { get; }
        int FlatFootedAc { get; }
        int TouchAc { get; }

        int FortitudeSave { get; }
        int ReflexSave { get; }
        int WillSave { get; }
    }
}