namespace Domain.DTOs;

public class SearhUserParametersDto
{
    public string? UsernameContains { get; }

    public SearhUserParametersDto(string? usernameContains)
    {
        UsernameContains = usernameContains;
    }
}