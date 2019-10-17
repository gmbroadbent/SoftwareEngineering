interface ATM
{
	float Current money available
	
	//Methods
		//Read Card
		//Get customer balance
		//Confirm PIN
}

interface Card
{
	int Account Number
	int Bank number
}

interface Customer_Account
{
	
	int Account Number
	int PIN
	float Balance
	
	//Methods
		//SetBalance
		//GetBalance
		//ConfirmPIN
}

interface Bank
{
	int Bank number
	int[] Account numbers
	
	//Methods
		//Get User details
		//Set User balance
}