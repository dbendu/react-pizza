namespace Domain.Pizza.Commands
{
    public record GetPizzasCommand(
        int Skip,
        int Take);
}
