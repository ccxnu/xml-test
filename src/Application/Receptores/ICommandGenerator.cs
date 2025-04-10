using MediatR;

public interface ICommandGenerator
{
    bool CanHandle(string content);
    IRequest<BaseResponse> GenerateCommand(string content);
}
