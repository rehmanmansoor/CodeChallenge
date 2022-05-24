# CodeChallenge

**Building and running Solution**
- Its build in VS2019, 
- Solution file in under CodeChallenge folder
- Open solution and restore the Nuget packages
- In VS2019 click IIS Express button in the ribbon menu, that will open browser and load the home page.


Project structure

  **Models are placed in Model folder**
  
    -LatestLotteriesResultsResponse.cs
    
    -LotteriesResultsParameter.cs
    
    -OpenLotteriesDrawsRequest.cs
    
    -OpenLotteriesDrawsResponse.cs
    
   **lottery Service and its interface is in lotteryService folder**
   
    -ILotteryService.cs
    
    -lotteryService.cs
    
   **Unit test**
   
    - CodeChallenge.Tests project is for Unit test
         
        -lotteryServiceTest.cs contain all the unit test
        
   **Run Test**
      Right click on the test and select Debug test, that will build the application and execute the selected test.
        
   **ERROR "Could not find a part of the path ... bin\roslyn\csc.exe"**
     run this in the Package Manager Console:
         Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
         https://stackoverflow.com/questions/32780315/could-not-find-a-part-of-the-path-bin-roslyn-csc-exe
         
    
      
    
