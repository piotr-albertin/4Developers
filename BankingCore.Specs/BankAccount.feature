Feature: BankAccount
	In order to manage personal finance
	As a bank account owner
	I want my financial transactions to be correctly maintained


Background: 
	Given I own a new bank account


Scenario Outline: Deposit money to a bank account
	When I deposit <deposit1>
		And  I deposit <deposit2>
	Then My account balance should be <balance>

	Examples: 
	| deposit1 | deposit2 | balance |
	| 100      | 200      | 300     |
	| 100      | 500      | 600     |
	| 0        | 100      | 100     |


Scenario: Multiple deposit money to a bank account
	When I deposit 100
		And I deposit 200
		And I deposit 50
	Then My account balance should be 350


Scenario: Withdraw money from a bank account
	When I have performed following transactions
	| transaction | amount |
	| deposit     | 100    |
	| deposit     | 300    |
	| withdraw    | 200    |
	| withdraw    | 100    |
	Then My account balance should be 100