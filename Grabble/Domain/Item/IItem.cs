namespace Grabble.Domain.Item
{
    internal interface IItem
    {
        void Patch();
        void Put();
        void Get();
        void Delete();
    }
}
