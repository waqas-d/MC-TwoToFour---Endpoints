

namespace MC_TwoToFour___Endpoints.Service.Nums;
public class AcceptsTwoNums : IAcceptsTwoNums
    {
    

    public string GetNumsResult(string firstNum, string secondNum)
    {
        double userFirstNum = Convert.ToDouble(firstNum);
        double userSecondNum = Convert.ToDouble(secondNum);
        double userNumResult = userFirstNum +  userSecondNum;
        
        return $"The sum of {userFirstNum} and {userSecondNum} is {userNumResult}";

    }

    }






   