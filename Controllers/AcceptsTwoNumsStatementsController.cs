using MC_TwoToFour___Endpoints.Service.Statements;
using Microsoft.AspNetCore.Mvc; // Added with [ApiController]

namespace MC_TwoToFour___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class AcceptsTwoNumsStatementsController : ControllerBase
    {
         private readonly IAcceptsTwoNumsStatements _AcceptsTwoNumsStatements;

    public AcceptsTwoNumsStatementsController(IAcceptsTwoNumsStatements AcceptsTwoNumsStatements){
        _AcceptsTwoNumsStatements = AcceptsTwoNumsStatements;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetResult/{firstStatement}/{secondStatement}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public string GetStatementResult(int firstNumStatement, int secondNumStatement)
    {   
        return _AcceptsTwoNumsStatements.GetStatementResult(firstNumStatement, secondNumStatement);
    }

    }





   