# Meal Suggestion App

## App Description
The application will allow users to:
- view, create, and delete dishes (breakfast / non-breakfast) that are candidates for suggestions, using a persistent database
- get a suggestion for a meal
- get suggestions for meal plans (breakfast, lunch, and dinner for a day), selecting the number of days

## Languages and Technologies
- C#
- Entity Framework
- Windows Presentation Foundation
- SQL

## How to Use the App
When you run the app, it shows you three buttons to move to other windows.
The back button on each window works the same. It leads back to the main window. 

### ManageDishes Window
- View: see the list of dishes in the database loaded on the data grid.
- Create: fill the dish name field, select if it is for breakfast or not, and click the Add-Dish button.
- Delete: after selecting a dish on the data grid, the dish ID to delete will be displayed for you above the Delete-Dish button. Click the Delete-Dish button when ready.

### SingleSuggestion Window
Select if you want a suggestion for breakfast or not. Then, click on the Get-Suggestion button. The suggestion will be displayed below the button. 

### MultipleSuggestions
Select the number of days (1-30) you want to get suggestions for. When you click on the Get-Suggestions button, the data grid beside will be populated.

## Features and Improvements to Explore
Check the list below for possible features and improvements you can make.
- Dividing dish types to breakfast, lunch, and dinner instead of breakfast or not
- Adding more fields other than the dish type and name
- Adding a feature allowing users to edit dish information
- Creating a search feature for dish management
- Adding more suggestion phrases other than "How about \<dish name\>?" and randomize them for display
- improving the UI components visually (adding colors, styling, organizing differently)
