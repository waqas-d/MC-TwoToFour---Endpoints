

namespace MC_TwoToFour___Endpoints.Service.Nums;
public class AcceptsTwoNums : IAcceptsTwoNums
    {
    

    public string GetNumsResult(int firstNum, int secondNum)
    {
        string userFirstNum = "";
        string userSecondNum = "";
        double userNumResult = Convert.ToDouble(userFirstNum +  userSecondNum);
        
        return $"The sum of {firstNum} and {secondNum} is  {userNumResult}";

    }

    }






   