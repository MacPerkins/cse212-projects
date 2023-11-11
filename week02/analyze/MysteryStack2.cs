/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code
 * with others or to post it online.  Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */
public static class MysteryStack2 { // A calculator!
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {  // a string of text
        var stack = new Stack<float>(); // a stack of floating point numbers
        foreach (var item in text.Split(' ')) { // split each item in the string
            if (item == "+" || item == "-" || item == "*" || item == "/") { // If the item or character is a mathmatical operator,
                if (stack.Count < 2)    // then check if the length of the stack is less than 2 (or 3 items since stacks start at 0)
                    throw new ApplicationException("Invalid Case 1!");  // if its less, throw an invalid case error message

                var op2 = stack.Pop();  // put the last item into op2
                var op1 = stack.Pop();  // put the next last item into op1
                float res;  //create a floating point number called res, or result
                if (item == "+") {  //if the item is addition, then perform addition on the 2 ops
                    res = op1 + op2;
                }
                else if (item == "-") {  //if the item is subtration, then perform subtraction on the 2 ops
                    res = op1 - op2;
                }
                else if (item == "*") {  //if the item is multiplication, then perform multiplication on the 2 ops
                    res = op1 * op2;
                }
                else {  //any other item will,
                    if (op2 == 0)   //check if op2 is zero,
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;    //if it isn't, do division on the 2 ops
                }

                stack.Push(res);    // put the result number on the top or end of the stack.
            }
            else if (IsFloat(item)) {   //if the item or character is a number,
                stack.Push(float.Parse(item));  //turn the item into a floating point number, and put it on top of the stack
            }
            else if (item == "") {  //if the item is blank or empty, do nothing
            }
            else {  //all other items that aren't a number or a mathmatical operator, throw an invalid case error message.
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)   //once done looping through all the items, check if the stack length is NOT 1 item (the result),
            throw new ApplicationException("Invalid Case 4!");  //if it isn't 1 item (the result), throw an invalid case error message.

        return stack.Pop();  //then remove the last item in the stack.
    }
}