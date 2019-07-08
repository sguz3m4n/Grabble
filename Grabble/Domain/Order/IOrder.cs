namespace Grabble.Domain.Order
{
    internal interface IOrder
    {
        void Patch();
        void Put();
        void Get();
        void Delete();
    }
}
