Feature: BankAccount
	In order to manage personal finance
	As a bank account owner
	I want my financial transactions to be correctly maintained

Scenario: Deposit money to a bank account
	Given I own a new bank account
	When I deposit 100
	Then My account balance should be 100

