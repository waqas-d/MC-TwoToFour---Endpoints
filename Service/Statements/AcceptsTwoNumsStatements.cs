namespace MC_TwoToFour___Endpoints.Service.Statements;
public class AcceptsTwoNumsStatements : IAcceptsTwoNumsStatements
{


    public string GetStatementResult(string firstNumStatement, string secondNumStatement)
    {
        // string userFirstNum = "";
        // string userSecondNum = "";
        double userFirstNumResult = Convert.ToDouble(firstNumStatement);
        double userSecondNumResult = Convert.ToDouble(secondNumStatement);
        if (userFirstNumResult > userSecondNumResult)
        {
            return $"{firstNumStatement} is greater than {secondNumStatement}.";
        }
        else if (userFirstNumResult < userSecondNumResult)
        {
            return $"{firstNumStatement} is less than {secondNumStatement}.";
        }
        else if (userFirstNumResult == userSecondNumResult)
        {
            return $"{firstNumStatement} is equal to {secondNumStatement}.";
        }

        if (userSecondNumResult > userFirstNumResult)
        {
            return $"{secondNumStatement} is greater than {secondNumStatement}.";
        }
        else if (userSecondNumResult < userFirstNumResult)
        {
            return $"{secondNumStatement} is less than {secondNumStatement}.";
        }
        else if (userSecondNumResult == userFirstNumResult)
        {
            return $"{secondNumStatement} is equal to {secondNumStatement}.";
        } 
        else {
            return "false";
        }
    }

}
