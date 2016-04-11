namespace MultimediaStore.Interfaces
{
    using MultimediaStore.Models;

    public interface IRent
    {
        IItem Item { get; }

        RentState RentState { get; }

        decimal RentFine { get; }

        void ReturnItem();
    }
}