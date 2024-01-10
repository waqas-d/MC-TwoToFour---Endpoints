namespace MC_TwoToFour___Endpoints.Service.Statements;
public class AcceptsTwoNumsStatements : IAcceptsTwoNumsStatements
{


    public string GetStatementResult(int firstNumStatement, int secondNumStatement)
    {
        string userFirstNum = "";
        string userSecondNum = "";
        double userFirstNumResult = Convert.ToDouble(userFirstNum);
        double userSecondNumResult = Convert.ToDouble(userSecondNum);
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

        else if (userSecondNumResult > userFirstNumResult)
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
    }

}
