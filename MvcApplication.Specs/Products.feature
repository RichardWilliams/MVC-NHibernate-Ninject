Feature: Products
	to have a collection of products for sale, 
	i need to be able to add products to
	the catalog


@addProduct
Scenario: Add Product
	Given I navigate to the 'Add Product' page
	And I enter a Name of 'TestProduct'
	And I enter a Price of '10.00'
	When I click 'SaveProduct'
	Then the last product should have title 'TestProduct'
	And the last product should have price '10.00'