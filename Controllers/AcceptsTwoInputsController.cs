using MC_TwoToFour___Endpoints.Service.Inputs;
using Microsoft.AspNetCore.Mvc; // Added with [ApiController]

namespace MC_TwoToFour___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class AcceptsTwoInputsController : ControllerBase
    {
         private readonly IAcceptsTwoInputs _AcceptsTwoInputs;

    public AcceptsTwoInputsController(IAcceptsTwoInputs AcceptsTwoInputs){
        _AcceptsTwoInputs = AcceptsTwoInputs;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetResult/{firstInput}/{secondInput}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public string GetInputResult(string firstInput, int secondInput)
    {   
        return _AcceptsTwoInputs.GetInputResult(firstInput, secondInput);
    }


    }



   