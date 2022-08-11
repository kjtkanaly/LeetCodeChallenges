public class Solution {
    
    private double modByValue;
    private double divideByValue;
    private double currentIndexValue;
    
    public  string   numberInWords = "";
    
    public string NumberToWords(int num) {
        
        if (num != 0)
        {
            string numString = num.ToString();
            int    numLength = numString.Length;

            for (int i = 0; i < numLength; i++)
            {
                modByValue         = (Math.Pow(10, i + 1)); 
                divideByValue      = (Math.Pow(10, i));
                currentIndexValue  = Math.Floor((num % modByValue) / divideByValue);

                ///////////////////////////////////////////////////////////
                //             Adding special Prefixes
                // Billion
                if (i == 9)
                {
                    numberInWords = "Billion " + numberInWords;
                }

                // Million
                if (i == 6)
                {
                    numberInWords = "Million " + numberInWords;
                }

                // Thousand
                if (i == 3)
                {
                    numberInWords = "Thousand " + numberInWords;
                }

                // Hundred
                if ((i == 8) || (i == 5) || (i == 2))
                {
                    numberInWords = "Hundred " + numberInWords;
                }

                ///////////////////////////////////////////////////////////
                //                   Tenths Place
                if ((i == 7) || (i == 4) || (i == 1))
                {
                    switch (currentIndexValue)
                    {
                        case 0:
                            break;
                        case 1:
                            numberInWords = "Ten " + numberInWords;
                            break;
                        case 2:
                            numberInWords = "Twenty " + numberInWords;
                            break;
                        case 3:
                            numberInWords = "Thirty " + numberInWords;
                            break;
                        case 4:
                            numberInWords = "Forty " + numberInWords;
                            break;
                        case 5:
                            numberInWords = "Fifty " + numberInWords;
                            break;
                        case 6:
                            numberInWords = "Sixty " + numberInWords;
                            break;
                        case 7:
                            numberInWords = "Seventy " + numberInWords;
                            break;
                        case 8:
                            numberInWords = "Eighty " + numberInWords;
                            break;
                        case 9:
                            numberInWords = "Ninety " + numberInWords;
                            break;
                    }
                }

                else
                {
                    switch (currentIndexValue)
                    {
                        case 0:
                            break;
                        case 1:
                            numberInWords = "One " + numberInWords;
                            break;
                        case 2:
                            numberInWords = "Two " + numberInWords;
                            break;
                        case 3:
                            numberInWords = "Three " + numberInWords;
                            break;
                        case 4:
                            numberInWords = "Four " + numberInWords;
                            break;
                        case 5:
                            numberInWords = "Five " + numberInWords;
                            break;
                        case 6:
                            numberInWords = "Six " + numberInWords;
                            break;
                        case 7:
                            numberInWords = "Seven " + numberInWords;
                            break;
                        case 8:
                            numberInWords = "Eight " + numberInWords;
                            break;
                        case 9:
                            numberInWords = "Nine " + numberInWords;
                            break;
                    }   
                }

            }

            numberInWords = numberInWords.Remove(numberInWords.Length - 1, 1);


            ///////////////////////////////////////////////////////////
            //             Accouting for the teens
            string[] numberInWordsSplit = numberInWords.Split(' ');
            for (int i = 0; i < numberInWordsSplit.Length - 1; i++)
            {
                if (numberInWordsSplit[i] == "Ten")
                {
                    switch(numberInWordsSplit[i + 1])
                    {
                        case "Zero":
                            numberInWordsSplit[i + 1] = "";
                            break;
                        case "One":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Eleven";
                            break;
                        case "Two":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Twelve";
                            break;
                        case "Three":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Thirteen";
                            break;
                        case "Four":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Fourteen";
                            break;
                        case "Five":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Fifteen";
                            break;
                        case "Six":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Sixteen";
                            break;
                        case "Seven":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Seventeen";
                            break;
                        case "Eight":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Eighteen";
                            break;
                        case "Nine":
                            numberInWordsSplit[i] = "";
                            numberInWordsSplit[i + 1] = "Nineteen";
                            break;
                    }
                }
            }
            
            /////////////////////////////////////////////////////////////
            // Checking for "Thousand Hundred" cases
            for (int i = 1; i < numberInWordsSplit.Length; i++)
            {
                if ((numberInWordsSplit[i] == "Hundred") || (numberInWordsSplit[i] == "Thousand") || 
                    (numberInWordsSplit[i] == "Million") || (numberInWordsSplit[i] == "Billion"))
                {
                    switch (numberInWordsSplit[i - 1])
                    {
                        case "Thousand":
                            numberInWordsSplit[i] = "";
                            break;
                        case "Million":
                            numberInWordsSplit[i] = "";
                            break;
                        case "Billion":
                            numberInWordsSplit[i] = "";
                            break;
                        case "":
                            numberInWordsSplit[i] = "";
                            break;
                    }
                }
            }

            /////////////////////////////////////////////////////////////
            // Stitching the numberInWords back toghether
            numberInWords = "";
            for (int i = 0; i < numberInWordsSplit.Length; i++)
            {
                if (numberInWordsSplit[i] != "")
                {
                    numberInWords = numberInWords + " " + numberInWordsSplit[i];   
                }
            }

            numberInWords = numberInWords.Remove(0, 1);
        }
        
        else
        {
            numberInWords = "Zero";
        }
        
        
        return numberInWords;
        
    }
}