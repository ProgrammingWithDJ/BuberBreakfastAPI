namespace BuberBreakfast.Contracts.BuberBreakfast;

public record CreateBreakFastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet);
