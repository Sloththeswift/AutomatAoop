# Vending machine console application
### School project in advanced object oriented programming.
### Written in C# using .net 7.
---
## About the application
### Simulates a vendingmachine which sells products ranging from smoked meats to hardware tools. The user starts with a fixed amount of loose change in the form of three types of swedish currency, which is a krona (1kr) a femma (5kr) and a tia (10kr), total value 160kr(ten of eact). These coins can be inserted in to the vendingmachine and used to buy products, when the transaction is done and the user exits the program the vendingmachine will return any eventual loose change which have not been spent, in the form of the highest value of coin possible.
---
## Navigating the application
### Input is read from the user which is directed towards the up and down arrow and enter keys, should the user press any other key nothing will happen. A skeleton class reads string arrays which is used as a menu navigator. Every menu or view makes an instance of the skeleton class and has its own separate string array with the specific information and choices for that particular menu. 
----
## Products
### The vendingmachine has a grand total of 9 products divided into 3 separate categorys, these are all based on an abstract class called products, the categories are: Food, Drinks and Utilities.
### The abstract class product uses the interface Iproduct which contains the methods Use() and BuyProduct(). 
### Use() prints out a string which is specific to the category, if you buy food it print "nom nom".
### BuyProduct() subtracts the price of a specific product from the vendingmachines balance, if it has determined that the user have deposited enough coins.
### Uses a static list from a static class called VendingMachince which contains all the different products, the products are then sorted and printed out in their respective categorys in the class.
### Product have a total of 5 variables which represents information, these are: Name, Description, Category, Price and Effect.
---

## Coins
### The currency used is stored in two classes, the users "Wallet" and the vending machines "Balance", The user upon starting the application has a total value of 160crowns divided in three forms of values, 10 pieces of every kind, and the vendingmachines balance starts with 0. 

## Wallet
### This static class contains 4 different integers which represent the different values and amount of coins, and also the total value of the coins combined. It also provides a interpolated volatile string which is used as a footer to display the current amount held in the users wallet.

## VendingMachine 
### A static class which contains a list of all the products which is provided to the menus. Also contains an integer representing the amount of coins inserted and a static interpolated volatile string which is used as a footer to display the vendingmachines balance.
---
## MenuSelector 
### This class build the functionality which is later used by a menu class to produce views, it reads indexes of string arrays and input from users by console.key, it also changes background and foreground of the console to indicate which specific step of the index is highlighted. 
### It also has a function that takes in the width and height of the console which can be used to alter the layout of the menu. 
---
## Menu 
### This class is the entrypoint and main menu of the application, it uses an instance of the menuselector for navigation and contains a string array that is used by a switch to determine where the user want to go. 
### Upon exiting the application a method inside the menuclass will subtract whats left of vendingmachinebalance and return what's left to the user in the form of the highest value of coin possible.  
---
## CoinBalance 
### This class provides the functionality need for the user to deposit coins into the vendingmachine, via the interface IvendingInterface.
### The user will be able to choose which type of coin to insert into the vendingmachine, one at a time. After a coin is "inserted" value of that coin gets subtracted from the users wallet and added to the vendingmachinebalance. 

