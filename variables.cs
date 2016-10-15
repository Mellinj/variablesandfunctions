//get the users choice

string chosenSoda = getSoda(0, false);

public string getSoda(int userchoice, bool shouldSing){
	string soda = "";
	//if the users choice is zero
	if (userChoice == 0) 
	{
    	soda="Root Beer";  
    } 
    else if(userChoice == 1)
    {
        soda="Cream Soda";
    } 
    else if(userChoice == 2)
    {
        soda="Orange";
    } 
    else if (userChoice == 3)
    {
    	soda="Diet Coke";
    } 
    else if (userChoice == 4)
    {
    	soda="Grape Soda";
    }
    
    
    if(shouldSing) {
        Console.WriteLine("I sing real good lalalala!");
    }
    
    return soda;
}
