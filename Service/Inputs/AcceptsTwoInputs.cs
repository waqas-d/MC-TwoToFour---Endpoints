namespace MC_TwoToFour___Endpoints.Service.Inputs;


public class AcceptsTwoInputs : IAcceptsTwoInputs
    {

    public string GetInputResult(string firstInput, int secondInput)
    {
    
        return $"My name is {firstInput} and I woke up at {secondInput}";


    }

}