namespace EntityData.Interfaces
{
    public interface IEntity
    {
        int CurrentHp { get; set; }
        int Ac { get; set; }
        int FortSave { get; set; }
        int ReflexSave { get; set; }
        int WillSave { get; set; }
        bool IsActive();
    }
}
