## Description of tasks

### PredictiveContactList

Introduction
Suppose a user wishes to find the name "cox" in a contact list. In a traditional "multi-tap" keypad entry system, it would be necessary to do the following:
- Press 2 (abc) three times to select c.
- Press 6 (mno) three times to select o.
- Press 9 (wxyz) twice to select x.

Meanwhile, in a predictive contact list, it is only necessary to:
- Press 2 once to select the (abc) group for the first character.
- Press 6 once to select the (mno) group for the second character.
- Press 9 once to select the (wxyz) group for the third character.
In this case, predictive mechanism reduced the number of button presses from 8 to 3.

This is a telephone keypad:

1 2-abc 3-def

4-ghi 5-jkl 6-mno

7-pqrs 8-tuv 9-wxyz

* 0 #

Task
Your task is to write a method that takes two arguments:
- contacts - a list of contacts stored in the phone (unordered list of strings containing the names with the lowercase english letters). This may be an empty list (but not null).
- keystrokes - a string which represents a sequence of keystrokes (only digits in the range [2,9]). This may be an empty sequence (but not null).
The method should return a list of possible contacts for the sequence of keystrokes using prediction mechanism.

Example
For input:
- contacts: ["jones", "thompson", "brown", "taylor", "bow", "smith", "cox", "timmons"]
- keystrokes: "2"
Output contact list should contain three names: ["brown", "bow", "cox"].

Article on Wikipedia about predictive text: https://en.wikipedia.org/wiki/Predictive_text

### ConnectFour

Connect Four
Take a look at wiki description of Connect Four game:

Wiki Connect Four: https://en.wikipedia.org/wiki/Connect_Four

The grid is 6 row by 7 columns, those being named from A to G.

You will receive a list of strings showing the order of the pieces which dropped in columns:

List<string> myList = new List<string>()
{
    "A_Red",
    "B_Yellow",
    "A_Red",
    "B_Yellow",
    "A_Red",
    "B_Yellow",
    "G_Red",
    "B_Yellow"
};
The list may contain up to 42 moves and shows the order the players are playing.

The first player who connects four items of the same color is the winner.

You should return "Yellow", "Red" or "Draw" accordingly.
