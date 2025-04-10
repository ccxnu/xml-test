using Microsoft.AspNetCore.Mvc;
using MediatR;

[ApiController]
[Route("api/[controller]")]
public class XmlController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ICommandGeneratorFactory _commandGeneratorFactory;

    public XmlController(IMediator mediator, ICommandGeneratorFactory commandGeneratorFactory)
    {
        _mediator = mediator;
        _commandGeneratorFactory = commandGeneratorFactory;
    }

    [HttpPost("process")]
    public async Task<IResult> ProcessXml()
    {
        using var reader = new StreamReader(Request.Body);
        var content = await reader.ReadToEndAsync();

        try
        {
            var command = _commandGeneratorFactory.GetGenerator(content).GenerateCommand(content);
            var result = await _mediator.Send(command);

            return Results.Extensions.Xml(result);
        }
        catch (InvalidOperationException ex)
        {
            return Results.BadRequest(ex.Message);
        }
    }
}
