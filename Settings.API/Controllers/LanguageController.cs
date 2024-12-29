using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Languages.Commands.CreateLanguage;
using Settings.Application.Features.Languages.Commands.DeleteLanguage;
using Settings.Application.Features.Languages.Commands.UpdateLanguage;
using Settings.Application.Features.Languages.Queries.GetAllLanguages;
using Settings.Application.Features.Languages.Queries.GetLanguageById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    private readonly IMediator _mediator;
    public LanguageController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var languageList = await _mediator.Send(new GetAllLanguagesQuery());
        return Ok(languageList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var language = await _mediator.Send(new GetLanguageByIdQuery { Id = Id });
        if (language is not null) { return Ok(language); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateLanguageCommand command)
    {
        await _mediator.Send(command);
        return Ok("Language Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateLanguageCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteLanguageCommand { Id = Id });
        return NoContent();
    }
}


















