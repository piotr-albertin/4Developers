Feature: BankAccount
	In order to manage personal finance
	As a bank account owner
	I want my financial transactions to be correctly maintained

@myTag
Scenario: Deposit money to a bank account
	Given I own a new bank account
	When I deposit 100
	Then My account balance should be 100

Scenario: Multiple deposit money to a bank account
	Given I own a new bank account
	When I deposit 100
	#ten krok jest zduplikowany - trzeba go sparametryzowac
	When I deposit 200
	Then My account balance should be 300
