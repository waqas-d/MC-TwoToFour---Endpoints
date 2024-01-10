using MC_TwoToFour___Endpoints.Service.Nums;
using Microsoft.AspNetCore.Mvc; // Added with [ApiController]

namespace MC_TwoToFour___Endpoints.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file
    public class AcceptsTwoNumsController : ControllerBase
    {
         private readonly IAcceptsTwoNums _AcceptsTwoNums;

    public AcceptsTwoNumsController(IAcceptsTwoNums AcceptsTwoNums){
        _AcceptsTwoNums = AcceptsTwoNums;
    }

    [HttpGet] // use Get to get/pull data
    [Route("GetResult/{firstNum}/{secondNum}")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public string GetNumsResult(string firstNum, string secondNum)
    {   
        return _AcceptsTwoNums.GetNumsResult(firstNum, secondNum);
    }


    }



   