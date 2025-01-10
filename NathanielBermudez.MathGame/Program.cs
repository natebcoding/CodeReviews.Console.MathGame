// Challenges
// [X]Try to implement levels of difficulty
// [x] Add a timer to track how long the user takes to finish the game
// [x] Create a 'Random Game' option where the players will be presented with questions from random operations


using NathanielBermudez.MathGame;

var menu = new Menu();

string name = Helpers.GetName();

var date = DateTime.UtcNow;

menu.ShowMenu(name, date);